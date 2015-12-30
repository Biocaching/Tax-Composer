using System;
using System.IO;
using System.Windows.Forms;
using System.Security.AccessControl;

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
               if (Directory.Exists(pathBox.Text) && hasWriteAccessToFolder(pathBox.Text))
               {
                    startForm.taxName = nameBox.Text;
                    startForm.taxSource = selectBox.Text;
                    startForm.taxPath = pathBox.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                } else
               {
                    MessageBox.Show("The path is not vaild or you are missing write access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Missing taxonomy name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool hasWriteAccessToFolder(string folderPath)
        {
            try
            {
                // Attempt to get a list of security permissions from the folder. 
                // This will raise an exception if the path is read only or do not have access to view the permissions. 
                DirectorySecurity dir = Directory.GetAccessControl(folderPath);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }
    }
}
