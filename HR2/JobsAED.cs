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
    public partial class JobsAED : Form
    {
        hr2 mainScreenForm;
        public JobsAED(hr2 formMainScreen)
        {
            InitializeComponent();
            mainScreenForm = formMainScreen;
        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDatabaseDataSet);

        }

        private void JobsAED_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.courseDatabaseDataSet.Job);
            this.WindowState = FormWindowState.Maximized;
            this.jobDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8);
            this.jobDataGridView.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            this.jobDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(41, 44, 51);
            sizeDGV(jobDataGridView);
        }


        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.Vertical;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, 266);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenForm.Show();
        }
    }
}
