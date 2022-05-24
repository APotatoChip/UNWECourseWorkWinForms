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
    public partial class CandidatesAED : Form
    {
        hr2 mainScreenForm;
        public CandidatesAED(hr2 formMainScreen)
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

        private void AED_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenForm.Show();
        }

        private void candidatesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
