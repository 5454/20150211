﻿namespace ProtobufEditer {
    partial class ProtobufEditer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRootMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEnumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.propertyPanel = new System.Windows.Forms.GroupBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.restrictLbl = new System.Windows.Forms.Label();
            this.nameIpt = new System.Windows.Forms.TextBox();
            this.defaultValueIpt = new System.Windows.Forms.TextBox();
            this.defaultLbl = new System.Windows.Forms.Label();
            this.restrictList = new System.Windows.Forms.ComboBox();
            this.commentIpt = new System.Windows.Forms.TextBox();
            this.numberLbl = new System.Windows.Forms.Label();
            this.commentLbl = new System.Windows.Forms.Label();
            this.numberTagUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataTypeList = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.AutoGenerateXMLCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveAsBtn = new System.Windows.Forms.Button();
            this.CompilerConfig = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.treeView = new System.Windows.Forms.TreeView();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.propertyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberTagUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 480);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(810, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "proto";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Protobuf File|*.proto";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "proto";
            this.saveFileDialog.Filter = "Protobuf File|*.proto";
            this.saveFileDialog.Title = "New Protobuf File";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRootMessageToolStripMenuItem,
            this.addMessageToolStripMenuItem,
            this.addFieldToolStripMenuItem,
            this.addEnumToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(174, 136);
            // 
            // addRootMessageToolStripMenuItem
            // 
            this.addRootMessageToolStripMenuItem.Name = "addRootMessageToolStripMenuItem";
            this.addRootMessageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addRootMessageToolStripMenuItem.Text = "Add Root Message";
            this.addRootMessageToolStripMenuItem.Click += new System.EventHandler(this.addRootMessageToolStripMenuItem_Click);
            // 
            // addMessageToolStripMenuItem
            // 
            this.addMessageToolStripMenuItem.Name = "addMessageToolStripMenuItem";
            this.addMessageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addMessageToolStripMenuItem.Text = "Add Message";
            this.addMessageToolStripMenuItem.Click += new System.EventHandler(this.addMessageToolStripMenuItem_Click);
            // 
            // addFieldToolStripMenuItem
            // 
            this.addFieldToolStripMenuItem.Name = "addFieldToolStripMenuItem";
            this.addFieldToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addFieldToolStripMenuItem.Text = "Add Field";
            this.addFieldToolStripMenuItem.Click += new System.EventHandler(this.addFieldToolStripMenuItem_Click);
            // 
            // addEnumToolStripMenuItem
            // 
            this.addEnumToolStripMenuItem.Name = "addEnumToolStripMenuItem";
            this.addEnumToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addEnumToolStripMenuItem.Text = "Add Enum";
            this.addEnumToolStripMenuItem.Click += new System.EventHandler(this.addEnumToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 570;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AutoGenerateXMLCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.SaveAsBtn);
            this.splitContainer1.Panel2.Controls.Add(this.CompilerConfig);
            this.splitContainer1.Panel2.Controls.Add(this.GenerateBtn);
            this.splitContainer1.Panel2.Controls.Add(this.NewBtn);
            this.splitContainer1.Panel2.Controls.Add(this.SaveBtn);
            this.splitContainer1.Panel2.Controls.Add(this.OpenBtn);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(810, 480);
            this.splitContainer1.SplitterDistance = 652;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.logBox);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(652, 480);
            this.splitContainer2.SplitterDistance = 278;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(5, 5);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.propertyPanel);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer3.Panel2MinSize = 200;
            this.splitContainer3.Size = new System.Drawing.Size(642, 268);
            this.splitContainer3.SplitterDistance = 373;
            this.splitContainer3.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(5, 5);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(363, 258);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // propertyPanel
            // 
            this.propertyPanel.Controls.Add(this.nameLbl);
            this.propertyPanel.Controls.Add(this.restrictLbl);
            this.propertyPanel.Controls.Add(this.nameIpt);
            this.propertyPanel.Controls.Add(this.defaultValueIpt);
            this.propertyPanel.Controls.Add(this.defaultLbl);
            this.propertyPanel.Controls.Add(this.restrictList);
            this.propertyPanel.Controls.Add(this.commentIpt);
            this.propertyPanel.Controls.Add(this.numberLbl);
            this.propertyPanel.Controls.Add(this.commentLbl);
            this.propertyPanel.Controls.Add(this.numberTagUpDown);
            this.propertyPanel.Controls.Add(this.dataTypeList);
            this.propertyPanel.Controls.Add(this.typeLbl);
            this.propertyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyPanel.Location = new System.Drawing.Point(5, 5);
            this.propertyPanel.Margin = new System.Windows.Forms.Padding(5);
            this.propertyPanel.Name = "propertyPanel";
            this.propertyPanel.Size = new System.Drawing.Size(255, 258);
            this.propertyPanel.TabIndex = 1;
            this.propertyPanel.TabStop = false;
            this.propertyPanel.Text = "Property";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(59, 27);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(29, 12);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restrictLbl
            // 
            this.restrictLbl.AutoSize = true;
            this.restrictLbl.Location = new System.Drawing.Point(35, 81);
            this.restrictLbl.Name = "restrictLbl";
            this.restrictLbl.Size = new System.Drawing.Size(53, 12);
            this.restrictLbl.TabIndex = 2;
            this.restrictLbl.Text = "Restrict";
            this.restrictLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameIpt
            // 
            this.nameIpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameIpt.Location = new System.Drawing.Point(96, 23);
            this.nameIpt.Name = "nameIpt";
            this.nameIpt.Size = new System.Drawing.Size(145, 21);
            this.nameIpt.TabIndex = 1;
            this.nameIpt.TextChanged += new System.EventHandler(this.nameIpt_TextChanged);
            // 
            // defaultValueIpt
            // 
            this.defaultValueIpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValueIpt.Location = new System.Drawing.Point(96, 50);
            this.defaultValueIpt.Name = "defaultValueIpt";
            this.defaultValueIpt.Size = new System.Drawing.Size(145, 21);
            this.defaultValueIpt.TabIndex = 13;
            this.defaultValueIpt.TextChanged += new System.EventHandler(this.defaultIpt_TextChanged);
            // 
            // defaultLbl
            // 
            this.defaultLbl.AutoSize = true;
            this.defaultLbl.Location = new System.Drawing.Point(11, 54);
            this.defaultLbl.Name = "defaultLbl";
            this.defaultLbl.Size = new System.Drawing.Size(77, 12);
            this.defaultLbl.TabIndex = 12;
            this.defaultLbl.Text = "DefaultValue";
            this.defaultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restrictList
            // 
            this.restrictList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restrictList.FormattingEnabled = true;
            this.restrictList.Items.AddRange(new object[] {
            "required",
            "optional",
            "repeated"});
            this.restrictList.Location = new System.Drawing.Point(96, 77);
            this.restrictList.Name = "restrictList";
            this.restrictList.Size = new System.Drawing.Size(145, 20);
            this.restrictList.TabIndex = 6;
            this.restrictList.SelectedIndexChanged += new System.EventHandler(this.restrictList_SelectedIndexChanged);
            // 
            // commentIpt
            // 
            this.commentIpt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentIpt.Location = new System.Drawing.Point(96, 160);
            this.commentIpt.Multiline = true;
            this.commentIpt.Name = "commentIpt";
            this.commentIpt.Size = new System.Drawing.Size(145, 84);
            this.commentIpt.TabIndex = 11;
            this.commentIpt.TextChanged += new System.EventHandler(this.commentIpt_TextChanged);
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Location = new System.Drawing.Point(29, 108);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(59, 12);
            this.numberLbl.TabIndex = 4;
            this.numberLbl.Text = "NumberTag";
            this.numberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // commentLbl
            // 
            this.commentLbl.AutoSize = true;
            this.commentLbl.Location = new System.Drawing.Point(41, 164);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Size = new System.Drawing.Size(47, 12);
            this.commentLbl.TabIndex = 10;
            this.commentLbl.Text = "Comment";
            this.commentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberTagUpDown
            // 
            this.numberTagUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberTagUpDown.Location = new System.Drawing.Point(96, 106);
            this.numberTagUpDown.Maximum = new decimal(new int[] {
            536870911,
            0,
            0,
            0});
            this.numberTagUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberTagUpDown.Name = "numberTagUpDown";
            this.numberTagUpDown.Size = new System.Drawing.Size(145, 21);
            this.numberTagUpDown.TabIndex = 7;
            this.numberTagUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberTagUpDown.ValueChanged += new System.EventHandler(this.numberUpDown_ValueChanged);
            // 
            // dataTypeList
            // 
            this.dataTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTypeList.AutoCompleteCustomSource.AddRange(new string[] {
            "double",
            "float",
            "int32",
            "int64",
            "uint32",
            "uint64",
            "sint32",
            "sint64",
            "fixed32",
            "fixed64",
            "sfixed32",
            "sfixed64",
            "bool",
            "string",
            "bytes"});
            this.dataTypeList.FormattingEnabled = true;
            this.dataTypeList.Items.AddRange(new object[] {
            "double",
            "float",
            "int32",
            "int64",
            "uint32",
            "uint64",
            "sint32",
            "sint64",
            "fixed32",
            "fixed64",
            "sfixed32",
            "sfixed64",
            "bool",
            "string",
            "bytes"});
            this.dataTypeList.Location = new System.Drawing.Point(96, 134);
            this.dataTypeList.Name = "dataTypeList";
            this.dataTypeList.Size = new System.Drawing.Size(145, 20);
            this.dataTypeList.TabIndex = 9;
            this.dataTypeList.SelectedIndexChanged += new System.EventHandler(this.typeList_SelectedIndexChanged);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(35, 137);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(53, 12);
            this.typeLbl.TabIndex = 8;
            this.typeLbl.Text = "DataType";
            this.typeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logBox.ForeColor = System.Drawing.Color.Yellow;
            this.logBox.Location = new System.Drawing.Point(10, 5);
            this.logBox.Margin = new System.Windows.Forms.Padding(0);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(632, 183);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            this.logBox.WordWrap = false;
            // 
            // AutoGenerateXMLCheckBox
            // 
            this.AutoGenerateXMLCheckBox.AutoSize = true;
            this.AutoGenerateXMLCheckBox.Checked = true;
            this.AutoGenerateXMLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoGenerateXMLCheckBox.Location = new System.Drawing.Point(16, 230);
            this.AutoGenerateXMLCheckBox.Name = "AutoGenerateXMLCheckBox";
            this.AutoGenerateXMLCheckBox.Size = new System.Drawing.Size(112, 16);
            this.AutoGenerateXMLCheckBox.TabIndex = 13;
            this.AutoGenerateXMLCheckBox.Text = "AutoGenerateXML";
            this.AutoGenerateXMLCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.AutoSize = true;
            this.SaveAsBtn.Location = new System.Drawing.Point(16, 120);
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.Size = new System.Drawing.Size(112, 30);
            this.SaveAsBtn.TabIndex = 12;
            this.SaveAsBtn.Text = "Save As";
            this.SaveAsBtn.UseVisualStyleBackColor = true;
            // 
            // CompilerConfig
            // 
            this.CompilerConfig.AutoSize = true;
            this.CompilerConfig.Location = new System.Drawing.Point(16, 192);
            this.CompilerConfig.Name = "CompilerConfig";
            this.CompilerConfig.Size = new System.Drawing.Size(112, 30);
            this.CompilerConfig.TabIndex = 11;
            this.CompilerConfig.Text = "CompilerConfig";
            this.CompilerConfig.UseVisualStyleBackColor = true;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.AutoSize = true;
            this.GenerateBtn.Location = new System.Drawing.Point(16, 156);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(112, 30);
            this.GenerateBtn.TabIndex = 10;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            // 
            // NewBtn
            // 
            this.NewBtn.AutoSize = true;
            this.NewBtn.Location = new System.Drawing.Point(16, 12);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(112, 30);
            this.NewBtn.TabIndex = 9;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.Location = new System.Drawing.Point(16, 84);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(112, 30);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.AutoSize = true;
            this.OpenBtn.Location = new System.Drawing.Point(16, 48);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(112, 30);
            this.OpenBtn.TabIndex = 7;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.ContextMenuStrip = this.contextMenuStrip;
            this.treeView.Location = new System.Drawing.Point(16, 162);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(80, 77);
            this.treeView.TabIndex = 0;
            this.treeView.Visible = false;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // ProtobufEditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 502);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(740, 488);
            this.Name = "ProtobufEditer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProtobufEditer";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.propertyPanel.ResumeLayout(false);
            this.propertyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberTagUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button CompilerConfig;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem addEnumToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameIpt;
        private System.Windows.Forms.Label restrictLbl;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.ComboBox restrictList;
        private System.Windows.Forms.NumericUpDown numberTagUpDown;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox dataTypeList;
        private System.Windows.Forms.Label commentLbl;
        private System.Windows.Forms.TextBox commentIpt;
        private System.Windows.Forms.Label defaultLbl;
        private System.Windows.Forms.TextBox defaultValueIpt;
        private System.Windows.Forms.ToolStripMenuItem addMessageToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox propertyPanel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button SaveAsBtn;
        private System.Windows.Forms.ToolStripMenuItem addRootMessageToolStripMenuItem;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.CheckBox AutoGenerateXMLCheckBox;
    }
}

