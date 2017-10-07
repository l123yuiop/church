using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms; //messagebox
using System.Data;
namespace church
{
    class dbInterface
    {
        //variable
        private string dbpath { set; get; }
        private OleDbConnection dbconnection ;
        public OleDbDataReader dbdr;
        public DataSet ds = new DataSet();
        //flag
        private bool connectionFlag = false;


        //Constructor
        public dbInterface()
        {

        }
        public dbInterface(string path)
        {
            dbpath = path;
        }

        //function
        /******* connection database  ********/
        public bool createdb()
        {
            string cn = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " + dbpath;
            dbconnection = new OleDbConnection(cn);
            try
            {
                dbconnection.Open();
                MessageBox.Show("資料庫開啟成功", "success");
                connectionFlag = true;
                return true;

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "資料庫讀取錯誤");
                dbconnection.Close();
                return false;

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "資料庫讀取錯誤");
                dbconnection.Close();
                return false;
            }
        }
        public void closedb()
        {
            if (connectionFlag)
            {
                 dbconnection.Close();
            }
        }
        /*************************************/
        
            
        /************** command   ***************/
        public bool dbcmd(string sqlcmd)
        {
            if (connectionFlag)
            {
                //command
                try
                {
                    OleDbCommand cmd = new OleDbCommand(sqlcmd, dbconnection);
                    dbdr = cmd.ExecuteReader();
                    return true;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "dbcmd");
                    return false;
                }
            }
            else
                return false;
        }
        public bool dbstore(string name,string number, string set, string tune,string band, string speed)
        {
            if (connectionFlag)
            {
                //command
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    
                    cmd.Connection = dbconnection;
                    cmd.CommandText = "SELECT MAX (隨機碼) FROM sq";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string gar = dr[0].ToString();
                    dr.Close();
                    cmd.Parameters.AddWithValue("@gar", int.Parse(gar));
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@number", number);
                    cmd.Parameters.AddWithValue("@set", int.Parse(set));
                    cmd.Parameters.AddWithValue("@tune", tune);
                    cmd.Parameters.AddWithValue("@band", band);
                    cmd.Parameters.AddWithValue("@speed", int.Parse(speed));
                    cmd.CommandText = "INSERT INTO sq(隨機碼,字數,編碼,歌名,樂團,曲調,速度) VALUES(@gar,@number,@set,@name,@band,@tune,@speed);";

                   cmd.ExecuteNonQuery();
                    return true;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "dbstore");
                    return false;
                }
            }
            else
                return false;
        }
        public bool dbtest(string sqlcmd)
        {
            if (connectionFlag)
            {
                //command
                try
                {
                    OleDbCommand cmd = new OleDbCommand();

                    cmd.Connection = dbconnection;
                    cmd.CommandText = sqlcmd;

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "dbstore");
                    return false;
                }
            }
            else
                return false;
        }
        public bool dbDataAdapter(string sqlcmd)
        {
            if (connectionFlag)
            {
                ds.Clear();
                try
                {
                    OleDbDataAdapter ap = new OleDbDataAdapter(sqlcmd, dbconnection);
                    ap.Fill(ds, "sq");

                    return true;
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message, "dbDataAdapter");
                    return false;
                }
            }
            else
                return false;
        }

    }
}
