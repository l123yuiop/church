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
