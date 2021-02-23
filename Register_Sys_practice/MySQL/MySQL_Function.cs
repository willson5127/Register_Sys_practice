using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Register_Sys_practice
{    
    public class MySQL_Function
    {
        private string connString = "server=127.0.0.1;port=3306;user id=root;password=1234;charset=utf8;";
        private MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        /// <summary>
        /// 初始化MySQL，包含連線SQL
        /// </summary>
        public MySQL_Function()
        {
            conn.ConnectionString = connString;
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }
        /// <summary>
        /// SELECT讀取資料庫
        /// </summary>
        /// <param name="commend">SQL指令</param>
        /// <returns></returns>
        public List<List<string>> Select(string commend)
        {
            //string result = "error";
            List<List<string>> list2 = new List<List<string>>();
            cmd = new MySqlCommand(@commend, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                List<string> list = new List<string>();
                if (!dr[0].Equals(DBNull.Value))
                {
                    for (int i = 0; i < dr.FieldCount; i++) list.Add(dr[i].ToString());
                }
                list2.Add(list);
            }
            dr.Close();
            return list2;
        }
        /// <summary>
        /// SELECT讀取資料庫
        /// </summary>
        /// <param name="commend">SQL指令</param>
        /// <param name="rowname">欄位名稱</param>
        /// <returns></returns>
        public string Select(string commend, string rowname)
        {
            string result = "error";
            cmd = new MySqlCommand(@commend, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (!dr[0].Equals(DBNull.Value))
                {
                    result = dr[rowname].ToString();
                }
            }
            dr.Close();
            return result;
        }
        /// <summary>
        /// SELECT讀取資料庫
        /// </summary>
        /// <param name="commend">SQL指令</param>
        /// <param name="rowname">檢視欄位</param>
        /// <param name="rn">是否跳行</param>
        /// <returns></returns>
        public string Select(string commend, string[] rowname, bool rn)
        {
            string result = "error", tmp = "";
            cmd = new MySqlCommand(@commend, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (!dr[0].Equals(DBNull.Value))
                {
                    for (int i = 0; i < rowname.Length; i++)
                    {
                        tmp += dr[rowname[i]].ToString();
                        if (i != rowname.Length - 1) tmp += ",\t";

                    }
                }
                if (rn) tmp += "\r\n";
            }
            result = tmp;
            dr.Close();
            return result;
        }
        /// <summary>
        /// 資料庫更新指令
        /// </summary>
        /// <param name="commend">SQL指令</param>
        /// <returns></returns>
        public int DataProcess(string commend)
        {
            cmd = new MySqlCommand(@commend, conn);
            return cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 關閉資料庫
        /// </summary>
        public void close()
        {
            conn.Close();
        }
    }
}