using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanLeLaptop
{
    public class CauHinh
    {
        public int check_Config()
        {
            if (Properties.Settings.Default.strSqlConnection == string.Empty)
                return 0;//Chuỗi cấu hình không tồn tại
            SqlConnection _sqlConn = new SqlConnection(Properties.Settings.Default.strSqlConnection);
            try
            {
                if (_sqlConn.State == System.Data.ConnectionState.Closed)
                    _sqlConn.Open();
                return 1; //Kết nối thành công
            }
            catch (Exception)
            {
                return 2; //Chuỗi cấu hình không hợp lệ
            }

        }

        //public enum LoginResult {Invalid, Disable, Success}

        //Lấy danh sách severname
        public DataTable GetServerName()
        {
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBNameByUser(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
            "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " +
            pPass + "");
            da.Fill(dt);
            return dt;
        }
        public DataTable GetDBNameByWindows(string pServer)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
            "Data Source=" + pServer + ";Initial Catalog=master;Integrated Security = True");
            da.Fill(dt);
            return dt;
        }
        public void SaveConfigUser(string pServer, string pUser, string pPass, string pDBName)
        {
            QuanLyCuaHangBanLeLaptop.Properties.Settings.Default.strSqlConnection = "Data source = " + pServer
                + ";Initial Catalog=" + pDBName + ";User ID = " + pUser + ";pwd= " + pPass + "";
            QuanLyCuaHangBanLeLaptop.Properties.Settings.Default.Save();
        }
        public void SaveConfigWindows(string pServer, string pDBName)
        {
            QuanLyCuaHangBanLeLaptop.Properties.Settings.Default.strSqlConnection = "Data source = " + pServer
                + ";Initial Catalog=" + pDBName + ";Integrated Security = True";
            QuanLyCuaHangBanLeLaptop.Properties.Settings.Default.Save();
        }
    }
}
