namespace church
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutxtMsg = new System.Windows.Forms.ToolStripTextBox();
            this.mnubtnAboutme = new System.Windows.Forms.ToolStripMenuItem();
            this.chkname = new System.Windows.Forms.CheckBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtband = new System.Windows.Forms.TextBox();
            this.chkband = new System.Windows.Forms.CheckBox();
            this.chktune = new System.Windows.Forms.CheckBox();
            this.txtsong = new System.Windows.Forms.TextBox();
            this.chksong = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.mnubtnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtndelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.chknumber = new System.Windows.Forms.CheckBox();
            this.cmbtune = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuset,
            this.mnutxtMsg,
            this.mnubtnAboutme});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuset
            // 
            this.mnuset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnCreate,
            this.mnubtnModify,
            this.mnubtndelete});
            this.mnuset.Name = "mnuset";
            this.mnuset.Size = new System.Drawing.Size(51, 27);
            this.mnuset.Text = "設定";
            // 
            // mnutxtMsg
            // 
            this.mnutxtMsg.Enabled = false;
            this.mnutxtMsg.Name = "mnutxtMsg";
            this.mnutxtMsg.Size = new System.Drawing.Size(200, 27);
            this.mnutxtMsg.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mnubtnAboutme
            // 
            this.mnubtnAboutme.Name = "mnubtnAboutme";
            this.mnubtnAboutme.Size = new System.Drawing.Size(51, 27);
            this.mnubtnAboutme.Text = "關於";
            this.mnubtnAboutme.Click += new System.EventHandler(this.mnubtnAboutme_Click);
            // 
            // chkname
            // 
            this.chkname.AutoSize = true;
            this.chkname.Location = new System.Drawing.Point(13, 58);
            this.chkname.Name = "chkname";
            this.chkname.Size = new System.Drawing.Size(74, 19);
            this.chkname.TabIndex = 1;
            this.chkname.Text = "找歌名";
            this.chkname.UseVisualStyleBackColor = true;
            this.chkname.CheckedChanged += new System.EventHandler(this.chkname_CheckedChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(91, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(163, 25);
            this.txtname.TabIndex = 2;
            // 
            // txtband
            // 
            this.txtband.Location = new System.Drawing.Point(91, 95);
            this.txtband.Name = "txtband";
            this.txtband.Size = new System.Drawing.Size(163, 25);
            this.txtband.TabIndex = 4;
            // 
            // chkband
            // 
            this.chkband.AutoSize = true;
            this.chkband.Location = new System.Drawing.Point(13, 99);
            this.chkband.Name = "chkband";
            this.chkband.Size = new System.Drawing.Size(74, 19);
            this.chkband.TabIndex = 3;
            this.chkband.Text = "找樂團";
            this.chkband.UseVisualStyleBackColor = true;
            this.chkband.CheckedChanged += new System.EventHandler(this.chkband_CheckedChanged);
            // 
            // chktune
            // 
            this.chktune.AutoSize = true;
            this.chktune.Location = new System.Drawing.Point(262, 56);
            this.chktune.Name = "chktune";
            this.chktune.Size = new System.Drawing.Size(74, 19);
            this.chktune.TabIndex = 5;
            this.chktune.Text = "找曲調";
            this.chktune.UseVisualStyleBackColor = true;
            this.chktune.CheckedChanged += new System.EventHandler(this.chktune_CheckedChanged);
            // 
            // txtsong
            // 
            this.txtsong.Location = new System.Drawing.Point(341, 95);
            this.txtsong.Name = "txtsong";
            this.txtsong.Size = new System.Drawing.Size(163, 25);
            this.txtsong.TabIndex = 8;
            // 
            // chksong
            // 
            this.chksong.AutoSize = true;
            this.chksong.Location = new System.Drawing.Point(262, 99);
            this.chksong.Name = "chksong";
            this.chksong.Size = new System.Drawing.Size(74, 19);
            this.chksong.TabIndex = 7;
            this.chksong.Text = "找歌詞";
            this.chksong.UseVisualStyleBackColor = true;
            this.chksong.CheckedChanged += new System.EventHandler(this.chksong_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(835, 368);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(638, 84);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(116, 36);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "查詢";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // mnubtnCreate
            // 
            this.mnubtnCreate.Name = "mnubtnCreate";
            this.mnubtnCreate.Size = new System.Drawing.Size(181, 26);
            this.mnubtnCreate.Text = "新增樂譜";
            // 
            // mnubtnModify
            // 
            this.mnubtnModify.Name = "mnubtnModify";
            this.mnubtnModify.Size = new System.Drawing.Size(181, 26);
            this.mnubtnModify.Text = "修改樂譜";
            // 
            // mnubtndelete
            // 
            this.mnubtndelete.Name = "mnubtndelete";
            this.mnubtndelete.Size = new System.Drawing.Size(181, 26);
            this.mnubtndelete.Text = "刪除樂譜";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(592, 48);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(163, 25);
            this.txtnumber.TabIndex = 12;
            // 
            // chknumber
            // 
            this.chknumber.AutoSize = true;
            this.chknumber.Location = new System.Drawing.Point(512, 54);
            this.chknumber.Name = "chknumber";
            this.chknumber.Size = new System.Drawing.Size(74, 19);
            this.chknumber.TabIndex = 11;
            this.chknumber.Text = "找字數";
            this.chknumber.UseVisualStyleBackColor = true;
            this.chknumber.CheckedChanged += new System.EventHandler(this.chknumber_CheckedChanged);
            // 
            // cmbtune
            // 
            this.cmbtune.FormattingEnabled = true;
            this.cmbtune.Items.AddRange(new object[] {
            "A",
            "Ab(G#)",
            "B",
            "Bb(A#)",
            "C",
            "D",
            "Db(C#)",
            "E",
            "Eb(D#)",
            "F",
            "G",
            "Gb(F#)"});
            this.cmbtune.Location = new System.Drawing.Point(341, 54);
            this.cmbtune.Name = "cmbtune";
            this.cmbtune.Size = new System.Drawing.Size(162, 23);
            this.cmbtune.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 495);
            this.Controls.Add(this.cmbtune);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.chknumber);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsong);
            this.Controls.Add(this.chksong);
            this.Controls.Add(this.chktune);
            this.Controls.Add(this.txtband);
            this.Controls.Add(this.chkband);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.chkname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuset;
        private System.Windows.Forms.ToolStripTextBox mnutxtMsg;
        private System.Windows.Forms.ToolStripMenuItem mnubtnAboutme;
        private System.Windows.Forms.CheckBox chkname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtband;
        private System.Windows.Forms.CheckBox chkband;
        private System.Windows.Forms.CheckBox chktune;
        private System.Windows.Forms.TextBox txtsong;
        private System.Windows.Forms.CheckBox chksong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ToolStripMenuItem mnubtnCreate;
        private System.Windows.Forms.ToolStripMenuItem mnubtnModify;
        private System.Windows.Forms.ToolStripMenuItem mnubtndelete;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.CheckBox chknumber;
        private System.Windows.Forms.ComboBox cmbtune;
    }
}

