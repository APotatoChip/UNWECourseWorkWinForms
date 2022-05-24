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
    public partial class JobCandidatesMD : Form
    {
        mainScreen mainScreenForm;
        public JobCandidatesMD(mainScreen formMainScreen)
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

        private void MD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.courseDatabaseDataSet.Candidates);
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.courseDatabaseDataSet.Job);
            this.WindowState = FormWindowState.Maximized;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenForm.Show();
        }
    }
}
