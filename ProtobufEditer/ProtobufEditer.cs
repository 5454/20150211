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
    public partial class ProtobufEditer : Form {
        private Dictionary<string, FileStream> fsList = new Dictionary<string, FileStream>();

        public enum NodeType { Message, Field, Enum }

        public ProtobufEditer() {
            InitializeComponent();
        }

        private string GetFileName(string pathName) {
            string fileName = pathName.Substring(pathName.LastIndexOf("\\") + 1);
            fileName = fileName.Split(new char[] { '.' })[0];
            return fileName;
        }

        private void AddFileToProcessList(string pathName, bool isOpen) {
            string fileName = GetFileName(pathName);
            if (fsList.ContainsKey(fileName) == false) {
                fsList.Add(fileName, new FileStream(pathName, isOpen == true ? FileMode.Open : FileMode.Create));
                tabControl.TabPages.Add(fileName);
                tabControl.TabPages[tabControl.TabPages.Count - 1].Name = fileName;
                logBox.AppendText("New Protobuf File >>> " + pathName + "\n");
            }
            tabControl.SelectTab(fileName);
            tabControl.SelectedTab.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;
            treeView.Visible = true;
        }

        private void NewBtn_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                AddFileToProcessList(saveFileDialog.FileName, false);
            }
        }


        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            if (e.Node.GetNodeCount(true) > 0) {
                e.Node.Expand();
            }
            if (treeView.SelectedNode.Tag.ToString() == NodeType.Message.ToString()) {
                defaultIpt.Enabled = false;
            }
            nameIpt.Text = e.Node.Name;

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
            fsList[tabControl.SelectedTab.Text].Close();
            fsList.Remove(tabControl.SelectedTab.Text);
            tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }

        private void OpenBtn_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                AddFileToProcessList(openFileDialog.FileName, true);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            tabControl.SelectedTab.Controls.Add(treeView);
        }

        private void addMessageToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            node = treeView.Nodes.Add("NewMessage");
            node.Name = "NewMessage";
            node.Tag = NodeType.Message;
        }

        private void addFieldToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag.ToString() != NodeType.Field.ToString()) {
                node = treeView.SelectedNode.Nodes.Add("NewField");
                node.Name = "NewField";
                node.Tag = NodeType.Field;
            }
        }

        private void addEnumToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag.ToString() == NodeType.Message.ToString()) {
                node = treeView.SelectedNode.Nodes.Add("NewEnum");
                node.Name = "NewEnum";
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
