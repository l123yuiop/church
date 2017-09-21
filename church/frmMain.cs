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
namespace church
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string mdbPath = Application.StartupPath + @"\..\..\mdb\chord.accdb";

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

            //check access database path  Spectrum
            MessageBox.Show("hello world");
            mnutxtMsg.Text = mdbPath;

            string cn = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = " + mdbPath;
            OleDbConnection db = new OleDbConnection(cn);
            try
            {
                db.Open();
                MessageBox.Show("mdb open success");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show( ex.ToString(), "OleDbException error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString(), "Exception error", MessageBoxButtons.OK);
            }
            OleDbDataAdapter ap = new OleDbDataAdapter("SELECT * FROM Spectrum", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "歌譜");
            dataGridView1.DataSource = ds.Tables["歌譜"];
            

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
