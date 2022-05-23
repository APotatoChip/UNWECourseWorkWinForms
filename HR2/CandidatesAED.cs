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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenForm.Show();
        }
    }
}
