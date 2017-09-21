namespace church
{
    partial class frmAboutMe
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(150, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "確認";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Enabled = false;
            this.txtMsg.Location = new System.Drawing.Point(38, 44);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(308, 234);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.Text = "關於我：\r\n此程式設計是為了讓主領能夠在家、工作中、吃飯中、可以有充裕的時間找詩歌，故作出這程式來。\r\n感謝：\r\n要幫我建檔的同工跟峻彥哥。\r\n\r\n\r\n\r\n\r\n\r" +
    "\n版本：1.1版\r\n版本時間：2017.9.21\r\n";
            // 
            // frmAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 371);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmAboutMe";
            this.Text = "關於我";
            this.Load += new System.EventHandler(this.frmAboutMe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMsg;
    }
}