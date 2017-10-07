using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace church
{
    public partial class frmedit : Form
    {
        public frmedit()
        {
            InitializeComponent();
        }

        private void frmedit_Load(object sender, EventArgs e)
        {
            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtband.Text = "";
            txtname.Text = "";
            txtnumber.Text = "";
            txtspeed.Text = "";
            txtset.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string sqlcmd = "INSERT INTO sq(字數,編碼,歌名,樂團,曲調,速度) VALUES(";
            sqlcmd += "'" + txtnumber.Text.Replace("'", "") + "'";
            sqlcmd += ",'" + txtset.Text.Replace("'", "") + "'";
            sqlcmd += ",N'" + txtname.Text.Replace("'", "") + "'";
            sqlcmd += ",N'" + txtband.Text.Replace("'", "") + "'";
            sqlcmd += ",'" + cmbtune.Text.Replace("'", "") + "'";
            sqlcmd += ",'" + txtspeed.Text.Replace("'", "") + "'";
            sqlcmd += ");";
            lblcmd.Text = sqlcmd;
            dbInterface db = new dbInterface(Application.StartupPath + @"\data\mdb\chord.mdb");
            string changeline = "\r\n";
            string msg = txtname.Text + changeline + txtnumber.Text + changeline + txtset.Text + changeline + txtspeed.Text + changeline + txtband.Text +changeline +cmbtune.Text;
            if (MessageBox.Show(msg, "新建檔案", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //database 
                
                db.createdb();
                //db.dbstore(txtname.Text,txtnumber.Text,txtset.Text,cmbtune.Text,txtband.Text,txtspeed.Text);
                db.dbtest(sqlcmd);
                db.closedb();
            }
        }

    }
}
