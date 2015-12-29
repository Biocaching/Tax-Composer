using System;
using System.IO;
using System.Windows.Forms;

namespace Tax_Composer
{
    public partial class NewTaxForm : Form
    {
        public NewTaxForm()
        {
            InitializeComponent();

            // select first option in source menu by default 
            selectBox.SelectedIndex = 0;
        }

        // Select location to store file
        private void folderBrowseBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.pathBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        // continue
        private void createBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "")
            {
               if(Directory.Exists(pathBox.Text))
               {
                    startForm.taxName = nameBox.Text;
                    startForm.taxSource = selectBox.Text;
                    startForm.taxPath = pathBox.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                } else
               {
                    MessageBox.Show("The path is not vaild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Missing taxonomy name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
