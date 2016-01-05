using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _02ZanCai_Ajax_Pro
{
    public static class SQLHelper
    {
        //  声明一个连接字符串
        public static readonly string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        //  打开字符串连接
        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            return conn;
        }

        public static int ExecuteNonQuery(string cmdText, params SqlParameter[] parameters)
        {
            using(SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                return ExecuteNonQuery(conn, cmdText, parameters);
            }
        }

        public static int ExecuteNonQuery(SqlConnection conn, string cmdText, params SqlParameter[] parameters)
        {
            using(SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string cmdText, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr)) 
            {
                conn.Open();
                return ExecuteScalar(conn, cmdText, parameters);
            }
        }

        public static object ExecuteScalar(SqlConnection conn, string cmdText, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }

        public static DataTable ExecuteDataTable(string cmdText, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                return ExecuteDataTable(conn, cmdText, parameters);
            }
        }

        public static DataTable ExecuteDataTable(SqlConnection conn, string cmdText, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Parameters.AddRange(parameters);
                using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }

        public static object ToDBValue(this object value)
        {
            return value == null ? DBNull.Value : value;
        }

        public static object FromDBValue(this object dbValue)
        {
            return dbValue == DBNull.Value ? null : dbValue;
        }
    }
}