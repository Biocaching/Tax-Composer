using System;
using System.Windows.Forms;

namespace Tax_Composer
{
    public partial class addCustomForm : Form
    {
        public Specie specie;
        public addCustomForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "")
            {
                specie = new Specie(true, null, nameBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Hide();
            } else
            {
                MessageBox.Show("Missing name of specie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
