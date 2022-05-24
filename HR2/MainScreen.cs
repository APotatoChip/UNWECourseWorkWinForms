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
    public partial class mainScreen : Form
    {
        SMP smp;
        SOP sop;
        JobCandidatesMD jobCandidatesMD;
        JobInterviewsMD jobInterviewsMD;
        CandidatesAED candidatesAED;
        JobsAED jobsAED;
        public mainScreen()
        {
            InitializeComponent();
            smp = new SMP(this);
            sop = new SOP(this);
            jobCandidatesMD = new JobCandidatesMD(this);
            jobInterviewsMD = new JobInterviewsMD(this);
            candidatesAED = new CandidatesAED(this);
            jobsAED = new JobsAED(this);
        }

        private void candidatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.candidatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.courseDatabaseDataSet.Candidates);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(41, 44, 51);
            menuLabel.Left = (this.ClientSize.Width - menuLabel.Width) / 2;
            candidatesFormBtn.Left = (this.ClientSize.Width - candidatesFormBtn.Width) / 2;
            SMP.Left = (this.ClientSize.Width - SMP.Width) / 2;
            SOP.Left = (this.ClientSize.Width - SOP.Width) / 2;
            jobsFormBtn.Left = (this.ClientSize.Width - jobsFormBtn.Width) / 2;
            jobCandidatesBtn.Left = (this.ClientSize.Width - jobCandidatesBtn.Width) / 2;
            jobInterviewsbtn.Left = (this.ClientSize.Width - jobInterviewsbtn.Width) / 2;
            exitBtn.Left = (this.ClientSize.Width - exitBtn.Width -2) ;
            //label3.Top = (this.ClientSize.Height - label3.Height) / 2;

        }

        private void candidatesFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            candidatesAED.Show();
        }

        private void jobsFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobsAED.Show();
        }
        private void SMP_Click(object sender, EventArgs e)
        {           
            this.Hide();
            smp.Show();
        }

        private void SOP_Click(object sender, EventArgs e)
        {
            this.Hide();
            sop.Show();
        }

        private void jobInterviewsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobInterviewsMD.Show();
        }

        private void jobCandidatesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobCandidatesMD.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
