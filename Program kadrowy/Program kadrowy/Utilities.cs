using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Program_kadrowy
{
    public static class Utilities
    {

        private static OracleConnection con = null;

        public static bool DatabaseConnection()
        {
            try
            {
                string conString = "User Id=root; password=12345;" + "Data Source=127.0.0.1:1521/oltpstud; Pooling=false;";
                con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                return true;
            }
            catch(Exception exc)
            {
                return false;
            }
        }
        public static OracleDataReader QueryResult(string queryCommand)
        {
            try
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = queryCommand;
                OracleDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd podczas wysyłania zapytania do bazy danych. Sprawdź swoje połączenie internetowe.", "Komunikat");
                return null;
            }
        }
        public static bool dmlOperation(List<string> cmdList)
        {
            try
            {
                OracleTransaction transaction = con.BeginTransaction();
                OracleCommand cmd = con.CreateCommand();
                cmd.Transaction = transaction;

                try
                {
                    foreach (string cmdText in cmdList)
                    {
                        cmd.CommandText = cmdText;
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception exc)
                {
                    transaction.Rollback();
                    MessageBox.Show("Błąd podczas próby zapisu do bazy danych. Sprawdź swoje połączenie internetowe.", "Komunikat");
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd podczas próby zapisu do bazy danych. Sprawdź swoje połączenie internetowe.", "Komunikat");
                return false;
            }
        }

        public static int GetId()
        {
            string cmd = "SELECT MAX(employee_id) + 1 FROM employees";
            OracleDataReader reader = QueryResult(cmd);
            if (reader != null && reader.Read())
            {
                return reader.GetInt32(0);
            }
            else
            {
                Program.EmpListAddr.Close();
                return -1;
            }
        }
    }
}
