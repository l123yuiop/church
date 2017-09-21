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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txt disable
            txtband.Enabled = false;
            txtname.Enabled = false;
            cmbtune.Enabled = false;
            cmbtune.SelectedIndex = 0;
            txtsong.Enabled = false;
            txtnumber.Enabled = false;
            //disabled search word of song mode
            chksong.Enabled = false;

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
                txtnumber.Enabled = true;
            }
            else
            {
                txtnumber.Enabled = false;
            }
        }
    }
}
