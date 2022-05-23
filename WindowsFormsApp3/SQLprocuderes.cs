using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class SQLprocuderes
    {
        public static string connstr = "Data Source=PC\\SQLEXPRESS;Initial Catalog=OnlineSchool;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstr);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;
        public static DataTable Refresh()
        {
            cmd = new SqlCommand("refresh", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;

        }
    }
}
