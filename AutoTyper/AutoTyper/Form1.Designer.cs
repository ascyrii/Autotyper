namespace AutoTyper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addMsgBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.alwaysOn = new System.Windows.Forms.CheckBox();
            this.intBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.startTool = new System.Windows.Forms.ToolTip(this.components);
            this.addTool = new System.Windows.Forms.ToolTip(this.components);
            this.removeTool = new System.Windows.Forms.ToolTip(this.components);
            this.removeAllTool = new System.Windows.Forms.ToolTip(this.components);
            this.alwaysOnTool = new System.Windows.Forms.ToolTip(this.components);
            this.mouseKeyEventProvider1 = new MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider();
            ((System.ComponentModel.ISupportInitialize)(this.intBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(210, 206);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start (F12)";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 93);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addMsgBtn
            // 
            this.addMsgBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMsgBtn.ForeColor = System.Drawing.Color.Black;
            this.addMsgBtn.Location = new System.Drawing.Point(12, 154);
            this.addMsgBtn.Name = "addMsgBtn";
            this.addMsgBtn.Size = new System.Drawing.Size(101, 23);
            this.addMsgBtn.TabIndex = 4;
            this.addMsgBtn.Text = "Add";
            this.addMsgBtn.UseVisualStyleBackColor = false;
            this.addMsgBtn.Click += new System.EventHandler(this.addMsgBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.ForeColor = System.Drawing.Color.Black;
            this.removeBtn.Location = new System.Drawing.Point(12, 180);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(101, 23);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(192, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Interval (In Seconds)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // alwaysOn
            // 
            this.alwaysOn.AutoSize = true;
            this.alwaysOn.Location = new System.Drawing.Point(12, 239);
            this.alwaysOn.Name = "alwaysOn";
            this.alwaysOn.Size = new System.Drawing.Size(106, 17);
            this.alwaysOn.TabIndex = 8;
            this.alwaysOn.Text = "Always-On Mode";
            this.alwaysOn.UseVisualStyleBackColor = true;
            this.alwaysOn.CheckedChanged += new System.EventHandler(this.alwaysOn_CheckedChanged);
            // 
            // intBox
            // 
            this.intBox.BackColor = System.Drawing.Color.White;
            this.intBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intBox.ForeColor = System.Drawing.Color.Black;
            this.intBox.Location = new System.Drawing.Point(210, 180);
            this.intBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.intBox.Name = "intBox";
            this.intBox.Size = new System.Drawing.Size(75, 20);
            this.intBox.TabIndex = 9;
            this.intBox.ThousandsSeparator = true;
            this.intBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intBox.ValueChanged += new System.EventHandler(this.intBox_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(297, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToTextFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openToolStripMenuItem.Text = "Load from Text File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToTextFileToolStripMenuItem
            // 
            this.saveToTextFileToolStripMenuItem.Name = "saveToTextFileToolStripMenuItem";
            this.saveToTextFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveToTextFileToolStripMenuItem.Text = "Save to Text File";
            this.saveToTextFileToolStripMenuItem.Click += new System.EventHandler(this.saveToTextFileToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text Files|*.txt; *.chiptune|All Files|*.*";
            this.openFileDialog1.InitialDirectory = "Desktop";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Load from Text File";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt;*.chiptune|All Files|*.*";
            this.saveFileDialog1.Title = "Save to Text File";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllBtn.Location = new System.Drawing.Point(12, 209);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(101, 23);
            this.removeAllBtn.TabIndex = 11;
            this.removeAllBtn.Text = "Remove All";
            this.removeAllBtn.UseVisualStyleBackColor = true;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // startTool
            // 
            this.startTool.ToolTipTitle = "Start/Stop";
            this.startTool.Popup += new System.Windows.Forms.PopupEventHandler(this.startTool_Popup);
            // 
            // addTool
            // 
            this.addTool.ToolTipTitle = "Add Line";
            // 
            // removeTool
            // 
            this.removeTool.ToolTipTitle = "Remove Selected";
            // 
            // removeAllTool
            // 
            this.removeAllTool.ToolTipTitle = "Remove All";
            // 
            // alwaysOnTool
            // 
            this.alwaysOnTool.ToolTipTitle = "Always-On Mode";
            // 
            // mouseKeyEventProvider1
            // 
            this.mouseKeyEventProvider1.Enabled = true;
            this.mouseKeyEventProvider1.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            this.mouseKeyEventProvider1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mouseKeyEventProvider1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(297, 268);
            this.Controls.Add(this.removeAllBtn);
            this.Controls.Add(this.intBox);
            this.Controls.Add(this.alwaysOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addMsgBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chiptuner\'s Auto Typer";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addMsgBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox alwaysOn;
        private System.Windows.Forms.NumericUpDown intBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToTextFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider mouseKeyEventProvider1;
        private System.Windows.Forms.Button removeAllBtn;
        private System.Windows.Forms.ToolTip startTool;
        private System.Windows.Forms.ToolTip addTool;
        private System.Windows.Forms.ToolTip removeTool;
        private System.Windows.Forms.ToolTip removeAllTool;
        private System.Windows.Forms.ToolTip alwaysOnTool;
    }
}

