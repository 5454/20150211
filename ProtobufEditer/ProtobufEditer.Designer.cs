namespace ProtobufEditer {
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
            this.addMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEnumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.logBox = new System.Windows.Forms.TextBox();
            this.CompilerLocalBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.treeView = new System.Windows.Forms.TreeView();
            this.propertyPanel = new System.Windows.Forms.Panel();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameIpt = new System.Windows.Forms.TextBox();
            this.restrictLbl = new System.Windows.Forms.Label();
            this.restrictList = new System.Windows.Forms.ComboBox();
            this.numberLbl = new System.Windows.Forms.Label();
            this.numberUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeLbl = new System.Windows.Forms.Label();
            this.typeList = new System.Windows.Forms.ComboBox();
            this.commentLbl = new System.Windows.Forms.Label();
            this.commentIpt = new System.Windows.Forms.TextBox();
            this.defaultLbl = new System.Windows.Forms.Label();
            this.defaultIpt = new System.Windows.Forms.TextBox();
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
            this.propertyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 437);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(694, 22);
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
            this.openFileDialog.Filter = "Protobuf File | *.proto";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "proto";
            this.saveFileDialog.Filter = "Protobuf File | *.proto";
            this.saveFileDialog.Title = "New Protobuf File";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMessageToolStripMenuItem,
            this.addFieldToolStripMenuItem,
            this.addEnumToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(146, 114);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // addMessageToolStripMenuItem
            // 
            this.addMessageToolStripMenuItem.Name = "addMessageToolStripMenuItem";
            this.addMessageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addMessageToolStripMenuItem.Text = "Add Message";
            // 
            // addFieldToolStripMenuItem
            // 
            this.addFieldToolStripMenuItem.Name = "addFieldToolStripMenuItem";
            this.addFieldToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addFieldToolStripMenuItem.Text = "Add Field";
            this.addFieldToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addEnumToolStripMenuItem
            // 
            this.addEnumToolStripMenuItem.Name = "addEnumToolStripMenuItem";
            this.addEnumToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addEnumToolStripMenuItem.Text = "Add Enum";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
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
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CompilerLocalBtn);
            this.splitContainer1.Panel2.Controls.Add(this.GenerateBtn);
            this.splitContainer1.Panel2.Controls.Add(this.NewBtn);
            this.splitContainer1.Panel2.Controls.Add(this.SaveBtn);
            this.splitContainer1.Panel2.Controls.Add(this.OpenBtn);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 120;
            this.splitContainer1.Size = new System.Drawing.Size(694, 437);
            this.splitContainer1.SplitterDistance = 562;
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
            this.splitContainer2.Panel1.Controls.Add(this.tabControl);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.logBox);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(562, 437);
            this.splitContainer2.SplitterDistance = 254;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(562, 254);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logBox.ForeColor = System.Drawing.Color.Yellow;
            this.logBox.Location = new System.Drawing.Point(0, 0);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(562, 179);
            this.logBox.TabIndex = 0;
            // 
            // CompilerLocalBtn
            // 
            this.CompilerLocalBtn.AutoSize = true;
            this.CompilerLocalBtn.Location = new System.Drawing.Point(16, 156);
            this.CompilerLocalBtn.Name = "CompilerLocalBtn";
            this.CompilerLocalBtn.Size = new System.Drawing.Size(95, 30);
            this.CompilerLocalBtn.TabIndex = 11;
            this.CompilerLocalBtn.Text = "CompilerLocal";
            this.CompilerLocalBtn.UseVisualStyleBackColor = true;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.AutoSize = true;
            this.GenerateBtn.Location = new System.Drawing.Point(16, 120);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(95, 30);
            this.GenerateBtn.TabIndex = 10;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            // 
            // NewBtn
            // 
            this.NewBtn.AutoSize = true;
            this.NewBtn.Location = new System.Drawing.Point(16, 12);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(95, 30);
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
            this.SaveBtn.Size = new System.Drawing.Size(95, 30);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // OpenBtn
            // 
            this.OpenBtn.AutoSize = true;
            this.OpenBtn.Location = new System.Drawing.Point(16, 48);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(95, 30);
            this.OpenBtn.TabIndex = 7;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.ContextMenuStrip = this.contextMenuStrip;
            this.treeView.Location = new System.Drawing.Point(16, 162);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(80, 77);
            this.treeView.TabIndex = 0;
            this.treeView.Visible = false;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // propertyPanel
            // 
            this.propertyPanel.BackColor = System.Drawing.SystemColors.Control;
            this.propertyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propertyPanel.Controls.Add(this.nameLbl);
            this.propertyPanel.Controls.Add(this.nameIpt);
            this.propertyPanel.Controls.Add(this.restrictLbl);
            this.propertyPanel.Controls.Add(this.restrictList);
            this.propertyPanel.Controls.Add(this.numberLbl);
            this.propertyPanel.Controls.Add(this.numberUpDown);
            this.propertyPanel.Controls.Add(this.typeLbl);
            this.propertyPanel.Controls.Add(this.typeList);
            this.propertyPanel.Controls.Add(this.commentLbl);
            this.propertyPanel.Controls.Add(this.commentIpt);
            this.propertyPanel.Controls.Add(this.defaultLbl);
            this.propertyPanel.Controls.Add(this.defaultIpt);
            this.propertyPanel.Location = new System.Drawing.Point(125, 36);
            this.propertyPanel.Name = "propertyPanel";
            this.propertyPanel.Size = new System.Drawing.Size(401, 178);
            this.propertyPanel.TabIndex = 0;
            this.propertyPanel.Visible = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(39, 15);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(29, 12);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameIpt
            // 
            this.nameIpt.Location = new System.Drawing.Point(76, 11);
            this.nameIpt.Name = "nameIpt";
            this.nameIpt.Size = new System.Drawing.Size(121, 21);
            this.nameIpt.TabIndex = 1;
            // 
            // restrictLbl
            // 
            this.restrictLbl.AutoSize = true;
            this.restrictLbl.Location = new System.Drawing.Point(15, 42);
            this.restrictLbl.Name = "restrictLbl";
            this.restrictLbl.Size = new System.Drawing.Size(53, 12);
            this.restrictLbl.TabIndex = 2;
            this.restrictLbl.Text = "Restrict";
            this.restrictLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restrictList
            // 
            this.restrictList.FormattingEnabled = true;
            this.restrictList.Items.AddRange(new object[] {
            "required",
            "optional",
            "repeated"});
            this.restrictList.Location = new System.Drawing.Point(76, 38);
            this.restrictList.Name = "restrictList";
            this.restrictList.Size = new System.Drawing.Size(121, 20);
            this.restrictList.TabIndex = 6;
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Location = new System.Drawing.Point(27, 69);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(41, 12);
            this.numberLbl.TabIndex = 4;
            this.numberLbl.Text = "Number";
            this.numberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberUpDown
            // 
            this.numberUpDown.Location = new System.Drawing.Point(76, 67);
            this.numberUpDown.Maximum = new decimal(new int[] {
            536870911,
            0,
            0,
            0});
            this.numberUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUpDown.Name = "numberUpDown";
            this.numberUpDown.Size = new System.Drawing.Size(121, 21);
            this.numberUpDown.TabIndex = 7;
            this.numberUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUpDown.ValueChanged += new System.EventHandler(this.numberUpDown_ValueChanged);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(39, 98);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(29, 12);
            this.typeLbl.TabIndex = 8;
            this.typeLbl.Text = "Type";
            this.typeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeList
            // 
            this.typeList.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.typeList.FormattingEnabled = true;
            this.typeList.Items.AddRange(new object[] {
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
            this.typeList.Location = new System.Drawing.Point(76, 95);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(121, 20);
            this.typeList.TabIndex = 9;
            // 
            // commentLbl
            // 
            this.commentLbl.AutoSize = true;
            this.commentLbl.Location = new System.Drawing.Point(21, 125);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Size = new System.Drawing.Size(47, 12);
            this.commentLbl.TabIndex = 10;
            this.commentLbl.Text = "Comment";
            this.commentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // commentIpt
            // 
            this.commentIpt.Location = new System.Drawing.Point(76, 121);
            this.commentIpt.Multiline = true;
            this.commentIpt.Name = "commentIpt";
            this.commentIpt.Size = new System.Drawing.Size(308, 44);
            this.commentIpt.TabIndex = 11;
            // 
            // defaultLbl
            // 
            this.defaultLbl.AutoSize = true;
            this.defaultLbl.Location = new System.Drawing.Point(210, 16);
            this.defaultLbl.Name = "defaultLbl";
            this.defaultLbl.Size = new System.Drawing.Size(47, 12);
            this.defaultLbl.TabIndex = 12;
            this.defaultLbl.Text = "Default";
            this.defaultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // defaultIpt
            // 
            this.defaultIpt.Location = new System.Drawing.Point(263, 12);
            this.defaultIpt.Name = "defaultIpt";
            this.defaultIpt.Size = new System.Drawing.Size(121, 21);
            this.defaultIpt.TabIndex = 13;
            // 
            // ProtobufEditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 459);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.propertyPanel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
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
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.propertyPanel.ResumeLayout(false);
            this.propertyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).EndInit();
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
        private System.Windows.Forms.Button CompilerLocalBtn;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem addEnumToolStripMenuItem;
        private System.Windows.Forms.Panel propertyPanel;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameIpt;
        private System.Windows.Forms.Label restrictLbl;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.ComboBox restrictList;
        private System.Windows.Forms.NumericUpDown numberUpDown;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox typeList;
        private System.Windows.Forms.Label commentLbl;
        private System.Windows.Forms.TextBox commentIpt;
        private System.Windows.Forms.Label defaultLbl;
        private System.Windows.Forms.TextBox defaultIpt;
        private System.Windows.Forms.ToolStripMenuItem addMessageToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

