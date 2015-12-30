using System;
using System.Xml;
using System.Windows.Forms;

namespace Tax_Composer
{
    public partial class addEolForm : Form
    {
        private string id;
        private string eolName;

        public Specie specie;

        private string url = "http://eol.org/api/search/1.0.xml?q=";

        public addEolForm()
        {
            InitializeComponent();
            resultContainer.Visible = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string url = this.url + eolSearchBox.Text;

            XmlDocument result = new XmlDocument();
            result.Load(url);

            if (result.GetElementsByTagName("entry")[0] != null)
            {
                this.eolName = result.DocumentElement.GetElementsByTagName("entry")[0].ChildNodes[0].InnerText;
                this.id = result.DocumentElement.GetElementsByTagName("entry")[0].ChildNodes[2].InnerText;
            } else
            {
                MessageBox.Show("No results found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            eolNameLbl.Text = "EOL: " + this.eolName;
            idLbl.Text = "ID: " + this.id;
            resultContainer.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.specie = new Specie(false, int.Parse(this.id), this.eolName);
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        // return press to act as searchBtn click
        private void searchBox_Enter(object sender, EventArgs e) { ActiveForm.AcceptButton = searchBtn; }
        private void searchBox_Leave(object sender, EventArgs e) { ActiveForm.AcceptButton = null; }
    }
}
