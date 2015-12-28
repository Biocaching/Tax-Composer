using System;
using System.Xml;
using System.Windows.Forms;

namespace Tax_Composer
{
    public partial class addArtsdatabankenForm : Form
    {
        private string id;
        private string nName;
        private string sName;

        public Specie specie;

        private string suggestUrl = "http://webtjenester.artsdatabanken.no/legacy/Artsnavnebase.asmx/Navnesok?max=10&search=";
        private string searchUrl = "http://webtjenester.artsdatabanken.no/legacy/Artsnavnebase.asmx/Artssok?search=";

        public addArtsdatabankenForm()
        {
            InitializeComponent();
            resultContainer.Visible = false;
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();
            string url = suggestUrl + searchBox.Text;

            XmlDocument result = new XmlDocument();
            result.Load(url);

            foreach (XmlNode xmlNode in result.DocumentElement)
            {
                list.Add(xmlNode.InnerText);
            }

            searchBox.AutoCompleteCustomSource = list;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string url = searchUrl + searchBox.Text;

            XmlDocument result = new XmlDocument();
            result.Load(url);

            if (result.DocumentElement.ChildNodes[0] != null)
            {
                this.id = result.DocumentElement.ChildNodes[0].Attributes["LatinskNavnID"].Value;
                this.sName = result.DocumentElement.GetElementsByTagName("VitenskapligNavn")[0].InnerText;

                if (result.DocumentElement.GetElementsByTagName("Popularnavn")[0] != null)
                {
                    this.nName = result.DocumentElement.GetElementsByTagName("Popularnavn")[0].ChildNodes[0].InnerText;
                } else
                {
                    this.Name = null;
                }
                
            } else
            {
                MessageBox.Show("No results found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nNameLbl.Text = "Norwegian: " + this.nName;
            sNameLbl.Text = "Scientific: " + this.sName;
            idLbl.Text = "ID: " + this.id;
            resultContainer.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (this.nName != null)
            {
                this.specie = new Specie(false, int.Parse(this.id), this.nName);
            } else
            {
                this.specie = new Specie(false, int.Parse(this.id), this.sName);
            }

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        // return press to act as searchBtn click
        private void searchBox_Enter(object sender, EventArgs e) { ActiveForm.AcceptButton = searchBtn; }
        private void searchBox_Leave(object sender, EventArgs e) { ActiveForm.AcceptButton = null; }
    }
}
