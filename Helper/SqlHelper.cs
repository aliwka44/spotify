using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SpAdo.Helper
{
    public class sqlhelper
    {
        const string connectionString = @"Server=DESKTOP-MPV3150\SQLEXPRESS;Database=Spotify;Trusted_Connection=True;";
        public static DataTable ExecuteQuery(string query)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }

        public static int Execute(string query)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand cmd = new SqlCommand(query, conn);

            return cmd.ExecuteNonQuery();

        }

        public static string HashPassword(string password)
        {
            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.Default.GetBytes(password)));
        }

        public static DataTable GetAll(string tableName)
        {
            string query = $"select * from {tableName}";

            return ExecuteQuery(query);
        }
        public static DataTable GetById(string tableName, int id)
        {
            string query = $"select * from {tableName} where Id = @Id";

            return ExecuteQuery(query);
        }
        public static void Delete(string tableName, int id)
        {
            SqlParameter parameterId = new SqlParameter("@Id", id);
            string query = $"delete from {tableName} where Id = @Id";
            ExecuteQuery(query);
        }

        internal static string HashPassword(object text)
        {
            throw new NotImplementedException();
        }
    }
}