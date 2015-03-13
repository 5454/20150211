using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace ProtobufEditer {
    public enum ProtobufNodeType { Message, Field, Enum }

    public enum ProtobufChildNodeType { Comment }

    public enum ProtobufAttribute { name, numberTag, restrict, defaultValue, dataType }

    public partial class ProtobufEditer : Form {
        private Dictionary<string, EditFiles> fileList = new Dictionary<string, EditFiles>();
        private int messageCount = 0;
        private int fieldCount = 0;
        private int enumCount = 0;
        private XmlElement selectedElement;

        public ProtobufEditer() {
            InitializeComponent();
        }

        private string GetFileName(string pathName) {
            string fileName = pathName.Substring(pathName.LastIndexOf("\\") + 1);
            fileName = fileName.Split(new char[] { '.' })[0];
            return fileName;
        }

        public int MessageCount {
            get {
                return messageCount += 1;
            }
        }

        public int FieldCount {
            get {
                return fieldCount += 1;
            }
        }

        public int EnumCount {
            get {
                return enumCount += 1;
            }
        }

        private void AddFileToProcessList(string pathName, bool isOpen) {
            string fileName = GetFileName(pathName);
            if (fileList.ContainsKey(pathName) == false) {
                EditFiles editFiles = new EditFiles();
                editFiles.protoFileStream = new FileStream(pathName, isOpen == true ? FileMode.Open : FileMode.Create);
                editFiles.xmlDocument = new XmlDocument();
                editFiles.xmlDocument.AppendChild(editFiles.xmlDocument.CreateElement(fileName));
                XmlDeclaration xmlDeclaration = editFiles.xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                editFiles.xmlDocument.InsertBefore(xmlDeclaration, editFiles.xmlDocument.DocumentElement);
                fileList.Add(pathName, editFiles);

                tabControl.TabPages.Add(fileName);
                tabControl.TabPages[tabControl.TabPages.Count - 1].Name = fileName;
                tabControl.TabPages[tabControl.TabPages.Count - 1].ToolTipText = pathName;
            }
            tabControl.SelectTab(fileName);
            tabControl.SelectedTab.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;
            treeView.Visible = true;
        }

        private void NewBtn_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                AddFileToProcessList(saveFileDialog.FileName, false);
                logBox.AppendText(Log.Instance.output(OperationType.New, TargetType.File, saveFileDialog.FileName));
            }
        }


        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {

            selectedElement = getSelectedElement();
            //logBox.AppendText(treeView.SelectedNode.FullPath + "\n");

            if (treeView.SelectedNode != null) {

                if (e.Node.GetNodeCount(true) > 0) {
                    e.Node.Expand();
                }

                if (treeView.SelectedNode.Tag.ToString() == ProtobufNodeType.Message.ToString()) {
                    defaultValueIpt.Enabled = false;
                    restrictList.Enabled = false;
                    numberTagUpDown.Enabled = false;
                    dataTypeList.Enabled = false;
                }
                if (treeView.SelectedNode.Tag.ToString() == ProtobufNodeType.Field.ToString()) {
                    defaultValueIpt.Enabled = true;
                    restrictList.Enabled = true;
                    numberTagUpDown.Enabled = true;
                    dataTypeList.Enabled = true;
                }
                if (treeView.SelectedNode.Tag.ToString() == ProtobufNodeType.Enum.ToString()) {
                    defaultValueIpt.Enabled = false;
                    restrictList.Enabled = false;
                    numberTagUpDown.Enabled = false;
                    dataTypeList.Enabled = false;
                }
                if (treeView.SelectedNode.Parent != null && treeView.SelectedNode.Parent.Tag.ToString() == ProtobufNodeType.Enum.ToString()) {
                    defaultValueIpt.Enabled = false;
                    restrictList.Enabled = false;
                    numberTagUpDown.Enabled = true;
                    dataTypeList.Enabled = false;
                }

                nameIpt.Text = e.Node.Text;

                if (selectedElement.GetAttribute(ProtobufAttribute.defaultValue.ToString()) != "") {
                    defaultValueIpt.Text = selectedElement.GetAttribute(ProtobufAttribute.defaultValue.ToString());
                } else {
                    defaultValueIpt.Text = "";
                }

                if (selectedElement.GetAttribute(ProtobufAttribute.restrict.ToString()) != "") {
                    restrictList.Text = selectedElement.GetAttribute(ProtobufAttribute.restrict.ToString());
                } else {
                    restrictList.Text = "";
                }

                if (selectedElement.GetAttribute(ProtobufAttribute.numberTag.ToString()) != "") {

                } else {

                }

                if (selectedElement.GetAttribute(ProtobufAttribute.dataType.ToString()) != "") {
                    dataTypeList.Text = selectedElement.GetAttribute(ProtobufAttribute.dataType.ToString());
                } else {
                    dataTypeList.Text = "";
                }


                if (getSelectedElement(ProtobufChildNodeType.Comment.ToString()) != null) {
                    commentIpt.Text = getSelectedElement(ProtobufChildNodeType.Comment.ToString()).InnerText;
                } else {
                    commentIpt.Text = "";
                }


            }
        }


        private decimal preNumber = 1;
        private void numberUpDown_ValueChanged(object sender, EventArgs e) {
            if (numberTagUpDown.Value >= 19000 && numberTagUpDown.Value <= 19999) {
                if (numberTagUpDown.Value > preNumber) {
                    numberTagUpDown.Value = 20000;
                } else {
                    numberTagUpDown.Value = 18999;
                }
            }
            preNumber = numberTagUpDown.Value;

            XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
            XmlElement docRoot = doc.DocumentElement;

            selectedElement.SetAttribute(ProtobufAttribute.numberTag.ToString(), numberTagUpDown.Value.ToString());
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            logBox.AppendText(Log.Instance.output(OperationType.Close, TargetType.File, tabControl.SelectedTab.Text));
            fileList[tabControl.SelectedTab.Text].protoFileStream.Close();
            fileList.Remove(tabControl.SelectedTab.Text);
            tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }

        private void OpenBtn_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                AddFileToProcessList(openFileDialog.FileName, true);
                logBox.AppendText(Log.Instance.output(OperationType.Open, TargetType.File, openFileDialog.FileName));
            }

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl.SelectedTab != null) {
                tabControl.SelectedTab.Controls.Add(treeView);
            }
        }
        private void addRootMessageToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            node = treeView.Nodes.Add("NewMessage_" + MessageCount);
            node.Name = node.Text;
            node.Tag = ProtobufNodeType.Message;
            XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
            XmlElement docRoot = doc.DocumentElement;

            XmlElement tempNode = doc.CreateElement(ProtobufNodeType.Message.ToString());
            XmlAttribute attribute = doc.CreateAttribute(ProtobufAttribute.name.ToString());
            attribute.Value = node.Name;
            tempNode.SetAttributeNode(attribute);
            docRoot.AppendChild(tempNode);
        }

        private void addMessageToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag.ToString() != ProtobufNodeType.Field.ToString() && treeView.SelectedNode.Tag.ToString() != ProtobufNodeType.Enum.ToString()) {
                node = treeView.SelectedNode.Nodes.Add("NewMessage_" + MessageCount);
                node.Name = node.Text;
                node.Tag = ProtobufNodeType.Message;

                XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
                XmlElement docRoot = doc.DocumentElement;

                XmlElement tempNode = doc.CreateElement(ProtobufNodeType.Message.ToString());
                selectedElement.AppendChild(tempNode);
                XmlAttribute attribute = doc.CreateAttribute(ProtobufAttribute.name.ToString());
                attribute.Value = node.Name;
                tempNode.SetAttributeNode(attribute);
            }
        }

        private void addFieldToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag.ToString() != ProtobufNodeType.Field.ToString()) {
                node = treeView.SelectedNode.Nodes.Add("NewField_" + FieldCount);
                node.Name = node.Text;
                node.Tag = ProtobufNodeType.Field;

                XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
                XmlElement docRoot = doc.DocumentElement;

                XmlElement tempNode = doc.CreateElement(ProtobufNodeType.Field.ToString());
                selectedElement.AppendChild(tempNode);
                XmlAttribute attribute = doc.CreateAttribute(ProtobufAttribute.name.ToString());
                attribute.Value = node.Name;
                tempNode.SetAttributeNode(attribute);

                attribute = doc.CreateAttribute(ProtobufAttribute.numberTag.ToString());
                attribute.Value = numberTagUpDown.Value.ToString();
                tempNode.SetAttributeNode(attribute);
            }
        }

        private void addEnumToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag.ToString() == ProtobufNodeType.Message.ToString()) {
                node = treeView.SelectedNode.Nodes.Add("NewEnum_" + EnumCount);
                node.Name = node.Text;
                node.Tag = ProtobufNodeType.Enum;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure Delete this Node ?", "Delete Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                treeView.SelectedNode.Remove();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            fileList[tabControl.SelectedTab.ToolTipText].xmlDocument.Save(tabControl.SelectedTab.ToolTipText.Replace(".proto", ".xml"));
        }

        private void nameIpt_TextChanged(object sender, EventArgs e) {
            treeView.SelectedNode.Name = nameIpt.Text;
            treeView.SelectedNode.Text = nameIpt.Text;

            XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
            XmlElement docRoot = doc.DocumentElement;

            selectedElement.SetAttribute(ProtobufAttribute.name.ToString(), nameIpt.Text);

        }


        private XmlElement getSelectedElement(string nodeName = "") {
            XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
            XmlElement docRoot = doc.DocumentElement;

            string xpath = "/AAA/" + selectedTreeNodeXPath + "[@" + ProtobufAttribute.name.ToString() + "='" + treeView.SelectedNode.Name + "']";
            if (nodeName != "") {
                xpath += "/" + nodeName;
            }

            logBox.AppendText(xpath + "\n");

            XmlNode selectedNode = doc.SelectSingleNode(xpath);
            return selectedNode as XmlElement;
        }


        private string selectedTreeNodeXPath {
            get {
                TreeNode selectedNode = treeView.SelectedNode;
                string rt = selectedNode.Tag.ToString();
                while (selectedNode.Parent != null) {
                    rt = selectedNode.Parent.Tag.ToString() + "/" + rt;
                    selectedNode = selectedNode.Parent;
                }
                return rt;
            }
        }

        private void commentIpt_TextChanged(object sender, EventArgs e) {
            XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
            XmlElement docRoot = doc.DocumentElement;

            XmlElement commentNode = getSelectedElement(ProtobufChildNodeType.Comment.ToString());
            if (commentNode == null) {
                commentNode = doc.CreateElement(ProtobufChildNodeType.Comment.ToString());
                selectedElement.AppendChild(commentNode);
            }

            if (commentIpt.Text != "") {
                commentNode.InnerText = "";
                XmlCDataSection cData = doc.CreateCDataSection(commentIpt.Text);
                commentNode.AppendChild(cData);
            } else {
                commentNode.ParentNode.RemoveChild(commentNode);
            }

        }

        private void defaultIpt_TextChanged(object sender, EventArgs e) {
            XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
            XmlElement docRoot = doc.DocumentElement;

            selectedElement.SetAttribute(ProtobufAttribute.defaultValue.ToString(), defaultValueIpt.Text);
        }

        private void restrictList_SelectedIndexChanged(object sender, EventArgs e) {
            XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
            XmlElement docRoot = doc.DocumentElement;

            selectedElement.SetAttribute(ProtobufAttribute.restrict.ToString(), restrictList.Text);
        }

        private void typeList_SelectedIndexChanged(object sender, EventArgs e) {
            XmlDocument doc = fileList[tabControl.SelectedTab.ToolTipText].xmlDocument;
            XmlElement docRoot = doc.DocumentElement;

            selectedElement.SetAttribute(ProtobufAttribute.dataType.ToString(), dataTypeList.Text);
        }



    }
}
