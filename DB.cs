using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PlantManager
{
    public class DB
    {
        const string CONNECTION_STRING = "Data Source=plantmanager.sqlite;Version=3;foreign keys=true;";
        private static SQLiteConnection m_dbConnection;

        public DB()
        {
        }

        public static void EnsureConnected()
        {
            if (m_dbConnection == null)
                Connect();
        }

        private static void Connect()
        {
            m_dbConnection = new SQLiteConnection(CONNECTION_STRING);


        }

        public static DataTable Query(string _request, params string[] _parameters )
        {
            EnsureConnected();
            SQLiteCommand command = new SQLiteCommand(m_dbConnection);
            command.CommandText = _request;

            for (int i = 0; i < _parameters.Length; i++)
            {
                command.Parameters.Add(new SQLiteParameter("", _parameters[i]));
            }

            m_dbConnection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            
            DataTable dTable = new DataTable();
            dTable.Load(reader);
            m_dbConnection.Close();
            return dTable;
        }

        public static DataRow QueryFirst(string _request, params string[] _parameters)
        {
            EnsureConnected();
            SQLiteCommand command = new SQLiteCommand(m_dbConnection);
            command.CommandText = _request;

            for (int i = 0; i < _parameters.Length; i++)
            {
                command.Parameters.Add(new SQLiteParameter ("", _parameters[i]));
            }

            m_dbConnection.Open();
            SQLiteDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
            DataTable dTable = new DataTable();
            dTable.Load(reader);
            m_dbConnection.Close();

            if (dTable.Rows.Count == 0)
                return null;

            return dTable.Rows[0];
        }


       /* public static void CreateDatabase()
        {
            SQLiteConnection.CreateFile("plantmanager.sqlite");
        }*/

        public static void Execute(string _request, params string[] _parameters)
        {
            EnsureConnected();
            SQLiteCommand command = new SQLiteCommand(m_dbConnection);
            command.CommandText = _request;

            for (int i = 0; i < _parameters.Length; i++)
            {
                command.Parameters.Add(new SQLiteParameter("", _parameters[i]));

            }

            m_dbConnection.Open();

            command.ExecuteNonQuery();

            m_dbConnection.Close();

        }
    }
}
