namespace church
{
    partial class frmedit
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtband = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblband = new System.Windows.Forms.Label();
            this.cmbtune = new System.Windows.Forms.ComboBox();
            this.lbltune = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtspeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtset = new System.Windows.Forms.TextBox();
            this.lblset = new System.Windows.Forms.Label();
            this.lblcmd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(583, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 27);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(483, 96);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(85, 27);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "重新";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(92, 72);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(143, 22);
            this.txtname.TabIndex = 2;
            // 
            // txtband
            // 
            this.txtband.Location = new System.Drawing.Point(313, 97);
            this.txtband.Name = "txtband";
            this.txtband.Size = new System.Drawing.Size(143, 22);
            this.txtband.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblname.Location = new System.Drawing.Point(30, 75);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(56, 16);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "歌名：";
            // 
            // lblband
            // 
            this.lblband.AutoSize = true;
            this.lblband.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblband.Location = new System.Drawing.Point(251, 100);
            this.lblband.Name = "lblband";
            this.lblband.Size = new System.Drawing.Size(56, 16);
            this.lblband.TabIndex = 5;
            this.lblband.Text = "樂團：";
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
            this.cmbtune.Location = new System.Drawing.Point(312, 71);
            this.cmbtune.Margin = new System.Windows.Forms.Padding(2);
            this.cmbtune.Name = "cmbtune";
            this.cmbtune.Size = new System.Drawing.Size(143, 20);
            this.cmbtune.TabIndex = 14;
            // 
            // lbltune
            // 
            this.lbltune.AutoSize = true;
            this.lbltune.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltune.Location = new System.Drawing.Point(251, 72);
            this.lbltune.Name = "lbltune";
            this.lbltune.Size = new System.Drawing.Size(56, 16);
            this.lbltune.TabIndex = 15;
            this.lbltune.Text = "曲調：";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblnumber.Location = new System.Drawing.Point(30, 103);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(56, 16);
            this.lblnumber.TabIndex = 16;
            this.lblnumber.Text = "字數：";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(91, 98);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(143, 22);
            this.txtnumber.TabIndex = 17;
            // 
            // txtspeed
            // 
            this.txtspeed.Location = new System.Drawing.Point(312, 123);
            this.txtspeed.Name = "txtspeed";
            this.txtspeed.Size = new System.Drawing.Size(143, 22);
            this.txtspeed.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(251, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "速度：";
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Location = new System.Drawing.Point(31, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(637, 54);
            this.lblMsg.TabIndex = 20;
            this.lblMsg.Text = "歡迎使用資料新增系統，請在相對應的空格內填入資料，填入完畢後按下新增完成建檔。\r\n如果需要清除所有空格內資料可按下重新鈕。";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtset
            // 
            this.txtset.Location = new System.Drawing.Point(92, 128);
            this.txtset.Name = "txtset";
            this.txtset.Size = new System.Drawing.Size(143, 22);
            this.txtset.TabIndex = 22;
            // 
            // lblset
            // 
            this.lblset.AutoSize = true;
            this.lblset.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblset.Location = new System.Drawing.Point(30, 130);
            this.lblset.Name = "lblset";
            this.lblset.Size = new System.Drawing.Size(56, 16);
            this.lblset.TabIndex = 21;
            this.lblset.Text = "編碼：";
            // 
            // lblcmd
            // 
            this.lblcmd.AutoSize = true;
            this.lblcmd.Location = new System.Drawing.Point(2, 168);
            this.lblcmd.Name = "lblcmd";
            this.lblcmd.Size = new System.Drawing.Size(0, 12);
            this.lblcmd.TabIndex = 23;
            // 
            // frmedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 189);
            this.Controls.Add(this.lblcmd);
            this.Controls.Add(this.txtset);
            this.Controls.Add(this.lblset);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtspeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lbltune);
            this.Controls.Add(this.cmbtune);
            this.Controls.Add(this.lblband);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtband);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增檔案資料";
            this.Load += new System.EventHandler(this.frmedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtband;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblband;
        private System.Windows.Forms.ComboBox cmbtune;
        private System.Windows.Forms.Label lbltune;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtspeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtset;
        private System.Windows.Forms.Label lblset;
        private System.Windows.Forms.Label lblcmd;
    }
}