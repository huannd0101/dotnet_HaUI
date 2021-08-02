using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Demo3Layer
{
    
    class DBConnection
    {
        public SqlConnection GetConnection()
        {
            string connString = @"Data Source=DESKTOP-3N3VG4I\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True";
            return new SqlConnection(connString);
        }

        public DataTable GetTable(string sql)
        {
            DataTable table = new DataTable();
            SqlConnection conn = GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(table);
            return table;
        }

        public void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable ExecuteReturnTable(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            conn.Close();
            return table;
        }
    }
}
