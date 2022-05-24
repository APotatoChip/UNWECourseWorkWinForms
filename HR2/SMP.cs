using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HR2
{
    public partial class SMP : Form
    {
        hr2 mainScreenForm;
        public SMP(hr2 formMainScreen)
        {
            InitializeComponent();
            mainScreenForm = formMainScreen;
        }

        private void candidatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.candidatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDatabaseDataSet);

        }

        private void SMP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDatabaseDataSet1.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter1.Fill(this.courseDatabaseDataSet1.Status);
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.courseDatabaseDataSet.Job);
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.courseDatabaseDataSet.Candidates);
            this.WindowState = FormWindowState.Maximized;
            this.candidatesDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8);
            this.candidatesDataGridView.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            this.candidatesDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(41, 44, 51);
            sizeDGV(candidatesDataGridView);
        }

        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.Vertical;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, 266);
        }


        private void button_Search_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (cbJobtitle.SelectedIndex > -1)
            {
                sb.AppendFormat("JobID = {0}",cbJobtitle.SelectedValue);
            }
            if (cbStatus.SelectedIndex > -1)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("Status = '{0}'",cbStatus.SelectedValue);
            }
            this.candidatesBindingSource.Filter = sb.ToString();
            this.candidatesTableAdapter.Fill(this.courseDatabaseDataSet.Candidates);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = -1;
            cbJobtitle.SelectedIndex = -1;
           
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new
           Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add();
            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel
            for (int i = 1; i < candidatesDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = candidatesDataGridView.Columns[i -
               1].HeaderText;
            }
            // storing Each row and column value to excel sheet
            for (int i = 0; i < candidatesDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < candidatesDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                   candidatesDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            // save the application and exit
            workbook.SaveAs("downloads\\output.xls");
            app.Quit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenForm.Show();
        }
    }
}
