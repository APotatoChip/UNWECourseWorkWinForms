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
    public partial class SOP : Form
    {
        hr2 mainScreenForm;
        public SOP(hr2 formMainScreen)
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

        private void SOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDatabaseDataSet.Candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.courseDatabaseDataSet.Candidates);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenForm.Show();
        }

        private void sopTextBox_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            //Debug.WriteLine(searchValue.Text.Equals(""));
            if (sopTextBox.Text.Equals(""))
            {
                this.candidatesBindingSource.DataSource = null;
            }
            else
            {
                sb.AppendFormat("Name like '%{0}%'", sopTextBox.Text);
                if (decimal.TryParse(sopTextBox.Text, out decimal valueNum))
                {
                    sb.AppendFormat(" or JobID={0}", valueNum);
                }
                this.candidatesBindingSource.DataSource = this.courseDatabaseDataSet.Candidates;
                this.candidatesBindingSource.Filter = sb.ToString();
                this.candidatesTableAdapter.Fill(this.courseDatabaseDataSet.Candidates);
            }
        }
    }
}
