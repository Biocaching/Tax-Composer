using System;
using System.Windows.Forms;

namespace Tax_Composer
{
    public partial class editCustomForm : Form
    {
        public Specie specie;

        public editCustomForm(Specie specie)
        {
            this.specie = specie;
            InitializeComponent();
            this.Text = specie.name;
            newNameBox.Text = specie.name;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (newNameBox.Text != "")
            {
                specie.name = newNameBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Hide();
            } else
            {
                MessageBox.Show("Missing name of specie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
