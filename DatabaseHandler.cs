using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Dota3InARow
{
    public static class DatabaseHandler
    {
        public static string ConnectionString { get => connectionString; set => connectionString = value; }
        public static OleDbConnection Connection { get => connection; set => connection = value; }

        public static bool IsUserExists(string nickname, Complication complication)
        {
            Connection.Open();
            string query = "Select Nickname from Records where Nickname = '" + nickname + "'" + "and Mode = '" + complication.ToString() + "'";

            OleDbCommand command = new OleDbCommand(query, Connection);

            bool result = command.ExecuteScalar() == null ? false : true;

            Connection.Close();
            return result;
        }

        public static int SelectCountOfPoints(string nickname, Complication complication)
        {
            Connection.Open();
            string query = "Select CountPoints from Records where Nickname = '" + nickname + "'" + "and Mode = '" + complication.ToString() + "'";

            OleDbCommand command = new OleDbCommand(query, Connection);

            int result = Convert.ToInt32(command.ExecuteScalar());

            Connection.Close();
            return result;
        }

        public static void InsertIntoRecords(string nickname, Complication complication, int countOfPoints)
        {
            Connection.Open();
            string query = "Insert into Records values('" + nickname + "'," + countOfPoints + ",'" + complication.ToString() + "')";

            OleDbCommand command = new OleDbCommand(query, Connection);

            command.ExecuteNonQuery();

            Connection.Close();
        }

        public static void UpdateRecords(string nickname, Complication complication, int countOfPoints)
        {
            Connection.Open();
            string query = "Update Records set CountPoints = " + countOfPoints + " where Nickname = '" + nickname + "'" + "and Mode = '" + complication.ToString() + "'";

            OleDbCommand command = new OleDbCommand(query, Connection);

            command.ExecuteNonQuery();

            Connection.Close();
        }

        public static List<User> SelectUsers(Complication complication)
        {
            Connection.Open();
            List<User> result = new List<User>();
            string query = "Select Nickname,CountPoints from Records where mode = '" + complication.ToString() + "'" + " order by CountPoints desc";

            OleDbCommand command = new OleDbCommand(query, Connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new User(reader[0].ToString(), Convert.ToInt32(reader[1])));
            }

            Connection.Close();
            return result;
        }

        private static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Records.mdb;";
        private static OleDbConnection connection = new OleDbConnection(connectionString);
    }
}
