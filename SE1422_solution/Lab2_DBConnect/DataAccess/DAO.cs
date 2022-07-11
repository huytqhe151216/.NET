using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DBConnect.DataAccess
{

    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string ConStr = config.GetConnectionString("MyConStr");
            return new SqlConnection(ConStr);
        }

        public static DataTable GetDataBySql(string sql, SqlParameter[] parameters)
        {
            // connect to sqlServer and get data
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int ExecuteSql(string sql, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            cmd.Connection.Open();
            int k = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return k;

        }
    }
}

