using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  // use accdb form access
using System.Data.SqlClient; //use 
namespace church
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string dbPath = Application.StartupPath + @"\data\mdb\chord.mdb";
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //txt disable
            txtband.Enabled = false;
            txtname.Enabled = false;
            cmbtune.Enabled = false;
            cmbtune.SelectedIndex = 0;
            txtsong.Enabled = false;
            cmbnumber.Enabled = false;
            cmbnumber.SelectedIndex = 0;
            //disabled search word of song mode
            chksong.Enabled = false;

            string cn = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " + dbPath;

            OleDbConnection db = new OleDbConnection(cn);
            db.Open();
            MessageBox.Show(db.DataSource, "資料來源");
            db.Close();


        }

        private void mnubtnAboutme_Click(object sender, EventArgs e)
        {
            frmAboutMe frm = new frmAboutMe();
            frm.Show();
            
        }


        //check change 

        private void chkname_CheckedChanged(object sender, EventArgs e)
        {
            if (chkname.Checked == true)
            {
                txtname.Enabled = true;
            }
            else
            {
                txtname.Enabled = false;
            }
        }
        private void chkband_CheckedChanged(object sender, EventArgs e)
        {
            if (chkband.Checked == true)
            {
                txtband.Enabled = true;
            }
            else
            {
                txtband.Enabled = false;
            }
        }
        private void chktune_CheckedChanged(object sender, EventArgs e)
        {
            if (chktune.Checked == true)
            {
                cmbtune.Enabled = true;
            }
            else
            {
                cmbtune.Enabled = false;
            }
        }
        private void chksong_CheckedChanged(object sender, EventArgs e)
        {
            if (chksong.Checked == true)
            {
                txtsong.Enabled = true;
            }
            else
            {
                txtsong.Enabled = false;
            }
        }
        private void chknumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chknumber.Checked == true)
            {
                cmbnumber.Enabled = true;
            }
            else
            {
                cmbnumber.Enabled = false;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
    }
}
