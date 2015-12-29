using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tax_Composer
{
    public partial class startForm : Form
    {
        public static string taxName;
        public static string taxPath; // only unsaved(first time)
        public static string taxSource;
        public static bool sourceFileExists = false;
        public static string sourceFile;
        public static string sourcePath;

        private static Specie activeSpecie;
        private TreeNodeMouseClickEventArgs activeNode;

        public startForm()
        {
            InitializeComponent();
        }

        private void newFileMainMenu_Click(object sender, EventArgs e)
        {
            NewTaxForm newTaxForm = new NewTaxForm();

            if (newTaxForm.ShowDialog() == DialogResult.OK)
            {
                sourceLbl.Text = sourceLbl.Text + taxSource;

                TreeNode root = new TreeNode(taxName);
                root.Tag = new Specie(true, null, taxName);
                taxTreeView.Nodes.Add(root);
                updateLabels();
            }
        }

        private void openFileMainMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Open XML Schema";
            fileDialog.Filter = "XML Files (*.xml)|*.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                TreeNode root = taxXml.parse(fileDialog.FileName);
                if (root != null)
                {
                    taxTreeView.Nodes.Clear();
                    taxTreeView.Nodes.Add(root);
                    taxTreeView.ExpandAll();
                    updateLabels();
                }
            }
        }

        // open context menu for nodes
        private void taxTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // context menu items can have been diabled before, re-enable the by default
                treeContextMenu.Items[1].Enabled = true;
                treeContextMenu.Items[2].Enabled = true;

                treeContextMenu.Show(taxTreeView, e.Location);
                activeNode = e;
                activeSpecie = Specie.toSpecie(e.Node.Tag);

                // if clicked node is root, disable "edit"/"remove" 
                if (activeNode.Node.Level == 0)
                {
                    treeContextMenu.Items[1].Enabled = false; // edit
                    treeContextMenu.Items[2].Enabled = false; // remove
                }

                // if it's not a custom Specie it can't be edited
                if (!activeSpecie.custom)
                {
                    treeContextMenu.Items[1].Enabled = false;  // edit
                }
            }
        }

        // add custom child
        private void customContextMenu_Click(object sender, EventArgs e)
        {
            addCustomForm addCustomForm = new addCustomForm();

            if (addCustomForm.ShowDialog() == DialogResult.OK)
            {
                Specie specie = addCustomForm.specie;
   
                TreeNode node = new TreeNode();
                node.Text = specie.name;
                node.Tag = specie;

                activeNode.Node.Nodes.Add(node);
                activeNode.Node.Expand();
                updateLabels();
            }
        }

        // add child from source
        private void fromSourceContextMenu_Click(object sender, EventArgs e)
        {
            switch(taxSource)
            {
                case "Artsdatabanken":
                    addArtsdatabankenForm addArtsdatabankenForm = new addArtsdatabankenForm();

                    if (addArtsdatabankenForm.ShowDialog() == DialogResult.OK)
                    {
                        Specie specie = addArtsdatabankenForm.specie;

                        TreeNode node = new TreeNode();
                        node.Text = specie.name;
                        node.Tag = specie;

                        activeNode.Node.Nodes.Add(node);
                        activeNode.Node.Expand();
                        updateLabels();
                    }
                    break;
                default:
                    MessageBox.Show("Unknown source defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        // edit
        private void editContextMenu_Click(object sender, EventArgs e)
        {
            editCustomForm editCustomForm = new editCustomForm(activeSpecie);

            if (editCustomForm.ShowDialog() == DialogResult.OK)
            {
                activeNode.Node.Tag = editCustomForm.specie;
                activeNode.Node.Text = editCustomForm.specie.name;
            }
        }

        // remove specie from tree
        private void removeContextMenu_Click(object sender, EventArgs e)
        {
            activeNode.Node.Remove();
            updateLabels();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           taxXml.write(taxTreeView);
        }

        private void updateLabels()
        {
            int level = getDeepestChildNodeLevel(taxTreeView.Nodes[0]);

            sourceLbl.Text = "Source: " + startForm.taxSource;
            depthLbl.Text = "Depth: " + level.ToString();
            itemsLbl.Text = "Items: " + taxTreeView.GetNodeCount(true).ToString();
        }

        private int getDeepestChildNodeLevel(TreeNode node)
        {
            // Modified version of http://stackoverflow.com/questions/8310601/find-the-level-of-deepest-child-treenode#answer-8310752
            IEnumerable<int> subLevel = node.Nodes.Cast<TreeNode>().Select(getDeepestChildNodeLevel);
            return subLevel.Count() == 0 ? 1 : subLevel.Max() + 1;
        }

        // keyboard shortcuts
        private void startForm_KeyDown(object sender, KeyEventArgs e)
        {
            //new file, Ctrl+n
            if(e.KeyCode == Keys.N && Control.ModifierKeys == Keys.Control) {
                newFileMainMenu.PerformClick();
            }
            //open file, Ctrl+o
            if (e.KeyCode == Keys.O && Control.ModifierKeys == Keys.Control)
            {
                openFileMainMenu.PerformClick();
            }
            //save file, Ctrl+s
            if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
            {
                saveFileMenuItem.PerformClick();
            }
        }
    }
}
