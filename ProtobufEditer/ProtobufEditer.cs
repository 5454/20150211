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

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node;
            if (treeView.SelectedNode != null) {
                node = treeView.SelectedNode.Nodes.Add("NewNode");
                node.Name = "NewNode";
            } else {
                node = treeView.Nodes.Add("NewMessage");
                node.Name = "NewMessage";
            }
            node.Text = node.Name;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            if (e.Node.GetNodeCount(true) > 0) {
                e.Node.Expand();
            }
            e.Node.ContextMenuStrip = contextMenuStrip;
            propertyPanel.Top = e.Node.Bounds.Top;
            propertyPanel.Left = e.Node.Bounds.Left + 50;
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

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e) {

        }


        private void tabControl_Click(object sender, EventArgs e) {
            if (tabControl.TabPages.Count > 0) {
                tabControl.ContextMenuStrip = contextMenuStrip;
                closeToolStripMenuItem.Visible = true;
                addEnumToolStripMenuItem.Visible = false;
                addFieldToolStripMenuItem.Visible = false;
                addMessageToolStripMenuItem.Visible = false;
                deleteToolStripMenuItem.Visible = false;
            } else {
                tabControl.ContextMenuStrip = null;
            }
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


        private void treeView_MouseClick(object sender, MouseEventArgs e) {
            if (treeView.Nodes.Count > 0 && treeView.SelectedNode != null) {
                propertyPanel.Visible = true;
            }
            //addFieldToolStripMenuItem.Visible = true;
            //addEnumToolStripMenuItem.Visible = true;
            //addMessageToolStripMenuItem.Visible = true;
            //deleteToolStripMenuItem.Visible = true;
            logBox.AppendText("......");
        }





    }
}
