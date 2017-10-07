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

        /*************  variable  *****************/

        //global
        int check_cnt = 0;
        
        //database 
        dbInterface db = new dbInterface(Application.StartupPath + @"\data\mdb\chord.mdb");
        DataSet ds = new DataSet();



        private void Form1_Load(object sender, EventArgs e)
        {
            //txt disable
            txtband.Enabled = false;
            txtname.Enabled = false;
            cmbtune.Enabled = false;
            cmbtune.SelectedIndex = 0;
            cmbnumber.Enabled = false;
            cmbnumber.SelectedIndex = 0;
            cmbspeed.Enabled = false;
            cmbspeed.SelectedIndex = 0;

            //db connection
            db.createdb();
            db.dbDataAdapter("SELECT * FROM sq ORDER BY 字數 ASC, 編碼 ASC ");
            //db.dbDataAdapter("SELECT * FROM sq  ");
            dataGridView1.DataSource = db.ds.Tables["sq"];
            

        }




        //check change 
        private void chkname_CheckedChanged(object sender, EventArgs e)
        {
            if (chkname.Checked == true)
            {
                txtname.Enabled = true;
                check_cnt++;
                //if (check_cnt == 1)
                //    btnsearch.Enabled = true;
            }
            else
            {
                txtname.Enabled = false;
                txtname.Text = "";
                check_cnt--;
                //if(check_cnt ==0 )
                //    btnsearch.Enabled = false;
            }
        }
        private void chkband_CheckedChanged(object sender, EventArgs e)
        {
            if (chkband.Checked == true)
            {
                txtband.Enabled = true;
                check_cnt++;
                //if (check_cnt == 1)
                //    btnsearch.Enabled = true;
            }
            else
            {
                txtband.Enabled = false;
                txtband.Text = "";
                check_cnt--;
                //if (check_cnt == 0)
                //    btnsearch.Enabled = false;
            }
        }
        private void chktune_CheckedChanged(object sender, EventArgs e)
        {
            if (chktune.Checked == true)
            {
                cmbtune.Enabled = true;
                check_cnt++;
                //if (check_cnt == 1)
                //    btnsearch.Enabled = true;
            }
            else
            {
                cmbtune.Enabled = false;
                check_cnt--;
                //if (check_cnt == 0)
                //    btnsearch.Enabled = false;
            }
        }
        private void chknumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chknumber.Checked == true)
            {
                cmbnumber.Enabled = true;
                check_cnt++;
                //if (check_cnt == 1)
                //    btnsearch.Enabled = true;
            }
            else
            {
                cmbnumber.Enabled = false;
                check_cnt--;
                //if (check_cnt == 0)
                //    btnsearch.Enabled = false;
            }
        }
        private void chkspeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkspeed.Checked == true)
            {
                cmbspeed.Enabled = true;
                check_cnt++;
                //if (check_cnt == 1)
                //    btnspeed.Enabled = true;
            }
            else
            {
                cmbspeed.Enabled = false;
                check_cnt--;
                //if (check_cnt == 0)
                //    btnspeed.Enabled = false;
            }
        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            bool firstFlag = false;
            string sqlcmd = "SELECT * FROM sq WHERE";

            //check search source
            if (chkname.Checked)
            {
                if (!firstFlag)
                {
                    firstFlag = true;
                    sqlcmd += " 歌名 LIKE '%" + txtname.Text + "%'";
                }
                else
                {
                    sqlcmd += " AND 歌名 LIKE '%" + txtname.Text + "%'";
                }

            }
            if (chkband.Checked)
            {
                if (!firstFlag)
                {
                    firstFlag = true;
                    sqlcmd += " 樂團 LIKE '%" + txtband.Text + "%'";
                }
                else
                {
                    sqlcmd += " AND 樂團 LIKE '%" + txtband.Text + "%'";
                }

            }
            if (chktune.Checked)
            {
                string tune = "";
                switch (cmbtune.Text)
                {
                    case "C":
                        tune = "IN ('C')";
                        break;
                    case "D":
                        tune = "IN ('D')";
                        break;
                    case "E":
                        tune = "IN ('E')";
                        break;
                    case "F":
                        tune = "IN ('F')";
                        break;
                    case "G":
                        tune = "IN ('G')";
                        break;
                    case "A":
                        tune = "IN ('A')";
                        break;
                    case "B":
                        tune = "IN ('B')";
                        break;
                    case "Db(C#)":
                        tune = "IN ('Db','C#')";
                        break;
                    case "Eb(D#)":
                        tune = "IN ('Eb','D#')";
                        break;
                    case "Gb(F#)":
                        tune = "IN ('Gb','F#')";
                        break;
                    case "Ab(G#)":
                        tune = "IN ('Ab','G#')";
                        break;
                    case "Bb(A#)":
                        tune = "IN ('Bb','A#')";
                        break;
                    default:
                        MessageBox.Show("此調性不存在", "曲調搜尋");
                        break;
                }
                if (!firstFlag)
                {

                    firstFlag = true;
                    sqlcmd += " 曲調 " + tune;
                }
                else
                {
                    sqlcmd += " AND 曲調 "+ tune;
                }

            }
            if (chknumber.Checked)
            {
                if (cmbnumber.Text != "other")
                {
                    if (!firstFlag)
                    {
                        firstFlag = true;
                        sqlcmd += " (字數 = " + cmbnumber.Text + ")";
                    }
                    else
                    {
                        sqlcmd += " AND (字數 = " + cmbnumber.Text + ")";
                    }
                }
                else
                {
                    if (!firstFlag)
                    {
                        firstFlag = true;
                        sqlcmd += " (字數  > 12)";
                    }
                    else
                    {
                        sqlcmd += " AND (字數  > 12)";
                    }
                }
            }
            if (chkspeed.Checked)
            {
                string speed = "";
                switch (cmbspeed.SelectedIndex)
                {
                    case 0:
                        speed = " (速度 < 90 )";
                        break;
                    case 1:
                        speed = " (速度 >= 90 AND 速度 < 110)";
                        break;
                    case 2:
                        speed = " (速度 >= 110 AND 速度 < 130)";
                        break;
                    case 3:
                        speed = " (速度 >= 130 AND 速度 < 150)";
                        break;
                    case 4:
                        speed = " (速度 >= 150 )";
                        break;
                    default:
                        MessageBox.Show("速度選項有誤", "速度搜尋");
                        break;
                }
                if (!firstFlag)
                {

                    firstFlag = true;
                    sqlcmd +=  speed;
                }
                else
                {
                    sqlcmd += " AND  " + speed;
                }
                MessageBox.Show(speed, "速度搜尋");
            }

            if (firstFlag)
            {
                //update datagridview
                sqlcmd += "ORDER BY 字數 ASC, 編碼 ASC";
                mnutxtMsg.Text = sqlcmd;
                db.dbDataAdapter(sqlcmd);

                dataGridView1.DataSource = db.ds.Tables["sq"];
            }
            else
            {
                sqlcmd = "SELECT * FROM sq ORDER BY 字數 ASC, 編碼 ASC ";
                mnutxtMsg.Text = sqlcmd;
                db.dbDataAdapter(sqlcmd);

                dataGridView1.DataSource = db.ds.Tables["sq"];
            }
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM sq ORDER BY 字數 ASC, 編碼 ASC ";
            mnutxtMsg.Text = sqlcmd;
            db.dbDataAdapter(sqlcmd);

            dataGridView1.DataSource = db.ds.Tables["sq"];
        }

        private void mnuset_Click(object sender, EventArgs e)
        {
            frmedit frm = new frmedit();
            frm.Show();
        }
        private void mnubtnAboutme_Click(object sender, EventArgs e)
        {
            frmAboutMe frm = new frmAboutMe();
            frm.Show();

        }
    }
}
