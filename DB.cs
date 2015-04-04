﻿using System.Data;
using System.Data.SQLite;

namespace PlantManager
{
    public class DB
    {
        private const string CONNECTION_STRING = "Data Source=plantmanager.sqlite;Version=3;foreign keys=true;";
        private static SQLiteConnection m_dbConnection;

        public static void EnsureConnected()
        {
            if (m_dbConnection == null)
                Connect();
        }

        private static void Connect()
        {
            m_dbConnection = new SQLiteConnection(CONNECTION_STRING);
        }

        public static DataTable Query(string _request, params string[] _parameters)
        {
            EnsureConnected();
            var command = new SQLiteCommand(m_dbConnection);
            command.CommandText = _request;

            for (var i = 0; i < _parameters.Length; i++)
            {
                command.Parameters.Add(new SQLiteParameter("", _parameters[i]));
            }

            m_dbConnection.Open();
            var reader = command.ExecuteReader();

            var dTable = new DataTable();
            dTable.Load(reader);
            m_dbConnection.Close();
            return dTable;
        }

        public static DataRow QueryFirst(string _request, params string[] _parameters)
        {
            EnsureConnected();
            var command = new SQLiteCommand(m_dbConnection);
            command.CommandText = _request;

            for (var i = 0; i < _parameters.Length; i++)
            {
                command.Parameters.Add(new SQLiteParameter("", _parameters[i]));
            }

            m_dbConnection.Open();
            var reader = command.ExecuteReader(CommandBehavior.SingleRow);
            var dTable = new DataTable();
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
            var command = new SQLiteCommand(m_dbConnection);
            command.CommandText = _request;

            for (var i = 0; i < _parameters.Length; i++)
            {
                command.Parameters.Add(new SQLiteParameter("", _parameters[i]));
            }

            m_dbConnection.Open();

            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }
    }
}