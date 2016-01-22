using System;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Tax_Composer
{
    class taxXml
    {
        private static StreamWriter writer;

        public static TreeNode parse(string filename)
        {
            try
            {
                XmlDocument result = new XmlDocument();
                result.Load(filename);

                // add root specie(taxname)
                TreeNode node = new TreeNode(result.DocumentElement.GetElementsByTagName("specie")[0].Attributes["name"].Value);
                node.Tag = new Specie(true, null, result.DocumentElement.GetElementsByTagName("specie")[0].Attributes["name"].Value);

                node = parseTreeNode(result.DocumentElement.GetElementsByTagName("specie")[0], node);


                startForm.taxSource = result.DocumentElement.GetElementsByTagName("source")[0].InnerText;
                startForm.sourceFileExists = true;
                startForm.taxName = result.DocumentElement.GetElementsByTagName("specie")[0].Value;
                startForm.sourceFile = filename;

                return node;
            } catch (XmlException)
            {
                MessageBox.Show("Error reading XML file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // return empty TreeNode
                return null;
            } catch (Exception)
            {
                MessageBox.Show("Error reading XML file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // return empty TreeNode
                return null;
            }
        }

        private static TreeNode parseTreeNode(XmlNode xmlNode, TreeNode node)
        {
            XmlNode xNode;
            TreeNode tNode;
            if (xmlNode.HasChildNodes)
            {
                XmlNodeList nodeList = xmlNode.ChildNodes;
                for (int i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = xmlNode.ChildNodes[i];
                    TreeNode newNode = new TreeNode(xNode.Attributes["name"].Value);
                    if (xNode.Attributes["id"] != null)
                    {
                        newNode.Tag = new Specie(false, int.Parse(xNode.Attributes["id"].Value), xNode.Attributes["name"].Value);    
                    } else
                    {
                        newNode.Tag = new Specie(true, null, xNode.Attributes["name"].Value);
                    }
                    node.Nodes.Add(newNode);
                    tNode = node.Nodes[i];
                    parseTreeNode(xNode, tNode);
                }

                return node;

            } else
            {
                return node;   
            }
        }

        public static void write(TreeView tree)
        {
            if (startForm.sourceFileExists)
            {
                composeAndSave(startForm.sourceFile, tree);
            } else
            {
                string dirPath = startForm.taxPath;
                char[] invalidFilenameChars = Path.GetInvalidFileNameChars();
                string validName = String.Join("_", startForm.taxName.Split(invalidFilenameChars, StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');

                if (validName == "")
                {
                    validName = "recentTax";
                }

                string fullFileName = dirPath + "\\" + validName + ".xml";
                composeAndSave(fullFileName, tree);
            }
        }

        private static void composeAndSave(string filename, TreeView tree)
        {
            writer = new StreamWriter(filename, false, Encoding.UTF8);
            
            writer.Write("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            writer.Write("<taxonomy-schema xmlns=\"http://biocaching.com/specs/taxonomy-schema/\" version=\"0.1\">");
            writer.Write("<source>" + startForm.taxSource + "</source>");
            writer.Write("<taxonomy>");
            parseTreeNode(tree.Nodes);
            writer.Write("</taxonomy>");
            writer.Write("</taxonomy-schema>");
            writer.Close();

            // update stuff in startForm.par
            startForm.sourceFile = filename;
            startForm.sourceFileExists = true;
        }

        private static string specieToElementString(Specie specie)
        {
            if (specie.custom)
            {
                return "<specie name=\"" + specie.name + "\">";
            } else
            {
                return "<specie id=\"" + specie.id + "\" name=\"" + specie.name + "\">";
            }
            
        }

        private static void parseTreeNode(TreeNodeCollection node)
        {
            foreach(TreeNode childNode in node)
            {
                if (childNode.Nodes.Count > 0)
                {
                    writer.Write(specieToElementString(Specie.toSpecie(childNode.Tag)));
                    parseTreeNode(childNode.Nodes);
                    writer.Write("</specie>");   
                } else
                {
                    writer.Write(specieToElementString(Specie.toSpecie(childNode.Tag)) + "</specie>");
                }
            }
        }
    }
}
