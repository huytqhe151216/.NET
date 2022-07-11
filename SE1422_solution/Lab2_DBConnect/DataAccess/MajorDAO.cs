using Lab2_DBConnect.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DBConnect.DataAccess
{
    internal class MajorDAO
    {
        private static List<Major> ConvetToListMajor(DataTable dt)
        {
            List<Major> list = new List<Major>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Major(
                    dr["Code"].ToString(),
                    dr["Title"].ToString()
                    )); ;
            }
            return list;
        }
        public static List<Major> GetAllMajor()
        {
            string sql = "select * from Major";
            DataTable dt = new DataTable();
            dt = DAO.GetDataBySql(sql, null);
            return ConvetToListMajor(dt);
        }
     }
}
