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
    public partial class hr2 : Form
    {
        SMP smp;
        SOP sop;
        MD md;
        CandidatesAED candidatesAED;
        JobsAED jobsAED;
        public hr2()
        {
            InitializeComponent();
            smp = new SMP(this);
            sop = new SOP(this);
            md = new MD(this);
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

        }

        private void candidatesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AED_Click(object sender, EventArgs e)
        {
            this.Hide();
            candidatesAED.Show();
        }

        private void SMP_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            smp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SOP_Click(object sender, EventArgs e)
        {
            this.Hide();
            sop.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void jobsAED_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobsAED.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            md.Show();
        }
    }
}
