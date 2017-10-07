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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutxtMsg = new System.Windows.Forms.ToolStripTextBox();
            this.mnubtnAboutme = new System.Windows.Forms.ToolStripMenuItem();
            this.chkname = new System.Windows.Forms.CheckBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtband = new System.Windows.Forms.TextBox();
            this.chkband = new System.Windows.Forms.CheckBox();
            this.chktune = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.chknumber = new System.Windows.Forms.CheckBox();
            this.cmbtune = new System.Windows.Forms.ComboBox();
            this.cmbnumber = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.cmbspeed = new System.Windows.Forms.ComboBox();
            this.chkspeed = new System.Windows.Forms.CheckBox();
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
            this.mnuset.Name = "mnuset";
            this.mnuset.Size = new System.Drawing.Size(68, 23);
            this.mnuset.Text = "修改資料";
            this.mnuset.Click += new System.EventHandler(this.mnuset_Click);
            // 
            // mnutxtMsg
            // 
            this.mnutxtMsg.Enabled = false;
            this.mnutxtMsg.Name = "mnutxtMsg";
            this.mnutxtMsg.Size = new System.Drawing.Size(600, 23);
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
            this.chkname.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(123, 22);
            this.txtname.TabIndex = 2;
            // 
            // txtband
            // 
            this.txtband.Location = new System.Drawing.Point(68, 76);
            this.txtband.Margin = new System.Windows.Forms.Padding(2);
            this.txtband.Name = "txtband";
            this.txtband.Size = new System.Drawing.Size(123, 22);
            this.txtband.TabIndex = 4;
            // 
            // chkband
            // 
            this.chkband.AutoSize = true;
            this.chkband.Location = new System.Drawing.Point(10, 79);
            this.chkband.Margin = new System.Windows.Forms.Padding(2);
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
            this.chktune.Margin = new System.Windows.Forms.Padding(2);
            this.chktune.Name = "chktune";
            this.chktune.Size = new System.Drawing.Size(60, 16);
            this.chktune.TabIndex = 5;
            this.chktune.Text = "找曲調";
            this.chktune.UseVisualStyleBackColor = true;
            this.chktune.CheckedChanged += new System.EventHandler(this.chktune_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(884, 441);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(545, 79);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
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
            this.chknumber.Location = new System.Drawing.Point(195, 78);
            this.chknumber.Margin = new System.Windows.Forms.Padding(2);
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
            "C",
            "Db(C#)",
            "D",
            "Eb(D#)",
            "E",
            "F",
            "Gb(F#)",
            "G",
            "Ab(G#)",
            "A",
            "Bb(A#)",
            "B"});
            this.cmbtune.Location = new System.Drawing.Point(273, 42);
            this.cmbtune.Margin = new System.Windows.Forms.Padding(2);
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
            this.cmbnumber.Location = new System.Drawing.Point(273, 75);
            this.cmbnumber.Name = "cmbnumber";
            this.cmbnumber.Size = new System.Drawing.Size(121, 20);
            this.cmbnumber.TabIndex = 14;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(443, 79);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(87, 29);
            this.btnreset.TabIndex = 15;
            this.btnreset.Text = "回首頁";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // cmbspeed
            // 
            this.cmbspeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbspeed.FormattingEnabled = true;
            this.cmbspeed.Items.AddRange(new object[] {
            "90↓(BPM)",
            "90~109(BPM)",
            "110~129(BPM)",
            "130~149(BPM)",
            "150↑(BPM)"});
            this.cmbspeed.Location = new System.Drawing.Point(510, 41);
            this.cmbspeed.Margin = new System.Windows.Forms.Padding(2);
            this.cmbspeed.Name = "cmbspeed";
            this.cmbspeed.Size = new System.Drawing.Size(122, 20);
            this.cmbspeed.TabIndex = 17;
            // 
            // chkspeed
            // 
            this.chkspeed.AutoSize = true;
            this.chkspeed.Location = new System.Drawing.Point(433, 44);
            this.chkspeed.Margin = new System.Windows.Forms.Padding(2);
            this.chkspeed.Name = "chkspeed";
            this.chkspeed.Size = new System.Drawing.Size(60, 16);
            this.chkspeed.TabIndex = 16;
            this.chkspeed.Text = "找速度";
            this.chkspeed.UseVisualStyleBackColor = true;
            this.chkspeed.CheckedChanged += new System.EventHandler(this.chkspeed_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.cmbspeed);
            this.Controls.Add(this.chkspeed);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.cmbnumber);
            this.Controls.Add(this.cmbtune);
            this.Controls.Add(this.chknumber);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chktune);
            this.Controls.Add(this.txtband);
            this.Controls.Add(this.chkband);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.chkname);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.CheckBox chknumber;
        private System.Windows.Forms.ComboBox cmbtune;
        private System.Windows.Forms.ComboBox cmbnumber;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ComboBox cmbspeed;
        private System.Windows.Forms.CheckBox chkspeed;
    }
}

