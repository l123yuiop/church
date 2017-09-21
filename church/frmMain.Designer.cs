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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtndelete = new System.Windows.Forms.ToolStripMenuItem();
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
            this.chknumber = new System.Windows.Forms.CheckBox();
            this.cmbtune = new System.Windows.Forms.ComboBox();
            this.cmbnumber = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(884, 27);
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
            this.mnuset.Size = new System.Drawing.Size(44, 23);
            this.mnuset.Text = "設定";
            // 
            // mnubtnCreate
            // 
            this.mnubtnCreate.Name = "mnubtnCreate";
            this.mnubtnCreate.Size = new System.Drawing.Size(124, 22);
            this.mnubtnCreate.Text = "新增樂譜";
            // 
            // mnubtnModify
            // 
            this.mnubtnModify.Name = "mnubtnModify";
            this.mnubtnModify.Size = new System.Drawing.Size(124, 22);
            this.mnubtnModify.Text = "修改樂譜";
            // 
            // mnubtndelete
            // 
            this.mnubtndelete.Name = "mnubtndelete";
            this.mnubtndelete.Size = new System.Drawing.Size(124, 22);
            this.mnubtndelete.Text = "刪除樂譜";
            // 
            // mnutxtMsg
            // 
            this.mnutxtMsg.Enabled = false;
            this.mnutxtMsg.Name = "mnutxtMsg";
            this.mnutxtMsg.Size = new System.Drawing.Size(400, 23);
            this.mnutxtMsg.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mnubtnAboutme
            // 
            this.mnubtnAboutme.Name = "mnubtnAboutme";
            this.mnubtnAboutme.Size = new System.Drawing.Size(44, 23);
            this.mnubtnAboutme.Text = "關於";
            this.mnubtnAboutme.Click += new System.EventHandler(this.mnubtnAboutme_Click);
            // 
            // chkname
            // 
            this.chkname.AutoSize = true;
            this.chkname.Location = new System.Drawing.Point(10, 46);
            this.chkname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkname.Name = "chkname";
            this.chkname.Size = new System.Drawing.Size(60, 16);
            this.chkname.TabIndex = 1;
            this.chkname.Text = "找歌名";
            this.chkname.UseVisualStyleBackColor = true;
            this.chkname.CheckedChanged += new System.EventHandler(this.chkname_CheckedChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(68, 43);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(123, 22);
            this.txtname.TabIndex = 2;
            // 
            // txtband
            // 
            this.txtband.Location = new System.Drawing.Point(68, 76);
            this.txtband.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtband.Name = "txtband";
            this.txtband.Size = new System.Drawing.Size(123, 22);
            this.txtband.TabIndex = 4;
            // 
            // chkband
            // 
            this.chkband.AutoSize = true;
            this.chkband.Location = new System.Drawing.Point(10, 79);
            this.chkband.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkband.Name = "chkband";
            this.chkband.Size = new System.Drawing.Size(60, 16);
            this.chkband.TabIndex = 3;
            this.chkband.Text = "找樂團";
            this.chkband.UseVisualStyleBackColor = true;
            this.chkband.CheckedChanged += new System.EventHandler(this.chkband_CheckedChanged);
            // 
            // chktune
            // 
            this.chktune.AutoSize = true;
            this.chktune.Location = new System.Drawing.Point(196, 45);
            this.chktune.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chktune.Name = "chktune";
            this.chktune.Size = new System.Drawing.Size(60, 16);
            this.chktune.TabIndex = 5;
            this.chktune.Text = "找曲調";
            this.chktune.UseVisualStyleBackColor = true;
            this.chktune.CheckedChanged += new System.EventHandler(this.chktune_CheckedChanged);
            // 
            // txtsong
            // 
            this.txtsong.Location = new System.Drawing.Point(256, 76);
            this.txtsong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsong.Name = "txtsong";
            this.txtsong.Size = new System.Drawing.Size(123, 22);
            this.txtsong.TabIndex = 8;
            // 
            // chksong
            // 
            this.chksong.AutoSize = true;
            this.chksong.Location = new System.Drawing.Point(196, 79);
            this.chksong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chksong.Name = "chksong";
            this.chksong.Size = new System.Drawing.Size(60, 16);
            this.chksong.TabIndex = 7;
            this.chksong.Text = "找歌詞";
            this.chksong.UseVisualStyleBackColor = true;
            this.chksong.CheckedChanged += new System.EventHandler(this.chksong_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(884, 441);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(449, 76);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(87, 29);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "查詢";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // chknumber
            // 
            this.chknumber.AutoSize = true;
            this.chknumber.Location = new System.Drawing.Point(384, 43);
            this.chknumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chknumber.Name = "chknumber";
            this.chknumber.Size = new System.Drawing.Size(60, 16);
            this.chknumber.TabIndex = 11;
            this.chknumber.Text = "找字數";
            this.chknumber.UseVisualStyleBackColor = true;
            this.chknumber.CheckedChanged += new System.EventHandler(this.chknumber_CheckedChanged);
            // 
            // cmbtune
            // 
            this.cmbtune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbtune.Location = new System.Drawing.Point(256, 43);
            this.cmbtune.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbtune.Name = "cmbtune";
            this.cmbtune.Size = new System.Drawing.Size(122, 20);
            this.cmbtune.TabIndex = 13;
            // 
            // cmbnumber
            // 
            this.cmbnumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnumber.FormattingEnabled = true;
            this.cmbnumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "other"});
            this.cmbnumber.Location = new System.Drawing.Point(449, 41);
            this.cmbnumber.Name = "cmbnumber";
            this.cmbnumber.Size = new System.Drawing.Size(121, 20);
            this.cmbnumber.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.cmbnumber);
            this.Controls.Add(this.cmbtune);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "詩歌譜搜尋系統";
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
        private System.Windows.Forms.CheckBox chknumber;
        private System.Windows.Forms.ComboBox cmbtune;
        private System.Windows.Forms.ComboBox cmbnumber;
    }
}

