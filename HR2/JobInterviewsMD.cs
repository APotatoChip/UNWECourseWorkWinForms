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
    public partial class JobInterviewsMD : Form
    {
        mainScreen mainScreenForm;
        public JobInterviewsMD(mainScreen formMainScreen)
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

        private void JobInterviewsMD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Interview' table. You can move, or remove it, as needed.
            this.interviewTableAdapter.Fill(this.courseDatabaseDataSet.Interview);
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.courseDatabaseDataSet.Job);
            this.interviewDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8);
            this.interviewDataGridView.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            this.interviewDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(41, 44, 51);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenForm.Show();
        }
    }
}
