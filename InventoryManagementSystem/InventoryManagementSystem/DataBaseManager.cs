using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InventoryManagementSystem
{
    class DataBaseManager
    {
        private static string connString = "Data Source=DESKTOP-S7J53V9;Initial Catalog=InventoryManagement;Integrated Security=True";

        public static List<Dictionary<String, String>> runSelectQuery(string query)
        {
            List<Dictionary<String, String>> data = new List<Dictionary<String, String>>();
            if (checkStringContainSelectQuery(query))
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read() && !sdr.IsDBNull(0))
                    {
                        Dictionary<String, String> row = new Dictionary<string, string>();
                            for (int i = 0; i < sdr.FieldCount; ++i)
                            {
                                row.Add(sdr.GetName(i), sdr.GetString(i));
                            }
                            data.Add(row);
                    }
                }
                conn.Close();
            }
            return data;
        }

        public static int runInsertAndUpdateAndDeleteQuery(string query)
        {
            int rowsAffected = 0;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                rowsAffected=cmd.ExecuteNonQuery();
            }
            conn.Close();
            return rowsAffected;
        }

        private static bool checkStringContainSelectQuery(string query)
        {
            return query.Contains("Select");
        }

        private static bool checkStringNotContainSelectQuery(string query)
        {
            bool update = true, insert= true;
            if (query.Contains("Update"))
                return update;
            else if (query.Contains("Insert"))
                return insert;
            else
                return false;
        }
    }
}
