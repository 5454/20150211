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

namespace ProtobufEditer {
    public enum NodeType { Message, Field, Enum }

    public partial class ProtobufEditer : Form {
        private Dictionary<string, FileStream> fsList = new Dictionary<string, FileStream>();
        private int messageCount = 0;
        private int fieldCount = 0;
        private int enumCount = 0;

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
            if (fsList.ContainsKey(fileName) == false) {
                fsList.Add(fileName, new FileStream(pathName, isOpen == true ? FileMode.Open : FileMode.Create));
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
            if (treeView.SelectedNode != null) {

                if (e.Node.GetNodeCount(true) > 0) {
                    e.Node.Expand();
                }

                if (treeView.SelectedNode.Tag.ToString() == NodeType.Message.ToString()) {
                    defaultIpt.Enabled = false;
                    restrictList.Enabled = false;
                    numberUpDown.Enabled = false;
                    typeList.Enabled = false;
                }
                if (treeView.SelectedNode.Tag.ToString() == NodeType.Field.ToString()) {
                    defaultIpt.Enabled = true;
                    restrictList.Enabled = true;
                    numberUpDown.Enabled = true;
                    typeList.Enabled = true;
                }
                if (treeView.SelectedNode.Tag.ToString() == NodeType.Enum.ToString()) {
                    defaultIpt.Enabled = false;
                    restrictList.Enabled = false;
                    numberUpDown.Enabled = false;
                    typeList.Enabled = false;
                }
                if (treeView.SelectedNode.Parent != null && treeView.SelectedNode.Parent.Tag.ToString() == NodeType.Enum.ToString()) {
                    defaultIpt.Enabled = false;
                    restrictList.Enabled = false;
                    numberUpDown.Enabled = true;
                    typeList.Enabled = false;
                }

                nameIpt.Text = e.Node.Text;
            }
        }


        private decimal preNumber = 1;
        private void numberUpDown_ValueChanged(object sender, EventArgs e) {
            if (numberUpDown.Value >= 19000 && numberUpDown.Value <= 19999) {
                if (numberUpDown.Value > preNumber) {
                    numberUpDown.Value = 20000;
                } else {
                    numberUpDown.Value = 18999;
                }
            }
            preNumber = numberUpDown.Value;
        }



        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            logBox.AppendText(Log.Instance.output(OperationType.Close, TargetType.File, tabControl.SelectedTab.Text));
            fsList[tabControl.SelectedTab.Text].Close();
            fsList.Remove(tabControl.SelectedTab.Text);
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
            node.Tag = NodeType.Message;
        }

        private void addMessageToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag.ToString() != NodeType.Field.ToString() && treeView.SelectedNode.Tag.ToString() != NodeType.Enum.ToString()) {
                node = treeView.SelectedNode.Nodes.Add("NewMessage_" + MessageCount);
                node.Name = node.Text;
                node.Tag = NodeType.Message;
            }
        }

        private void addFieldToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag.ToString() != NodeType.Field.ToString()) {
                node = treeView.SelectedNode.Nodes.Add("NewField_" + FieldCount);
                node.Name = node.Text;
                node.Tag = NodeType.Field;
            }
        }

        private void addEnumToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag.ToString() == NodeType.Message.ToString()) {
                node = treeView.SelectedNode.Nodes.Add("NewEnum_" + EnumCount);
                node.Name = node.Text;
                node.Tag = NodeType.Enum;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure Delete this Node ?", "Delete Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                treeView.SelectedNode.Remove();
            }
        }






    }
}
