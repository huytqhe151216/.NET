using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConnectDBUsingADO.DataAccess
{
    internal class DAO
    {
        public static SqlConnection GetConnecttion()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string ConStr = config.GetConnectionString("MyConStr");
            return new SqlConnection(ConStr);
        }

        public static DataTable GetDataBySql(string sql, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnecttion());
            //command.CommandText = sql;
            //command.Connection =GetConnecttion();
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);

            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static int ExecuteSql(string sql, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnecttion());
            if (parameters!=null)
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
