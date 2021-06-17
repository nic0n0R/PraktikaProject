using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PraktikaProject.CRUD.Create
{
    class DataWorker : IDataWorker
    {
        static string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        public DataTable ExecuteUserCommand(string command)
        {
            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand cmd = new OracleCommand(command, connection);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            oda.SelectCommand.ExecuteNonQuery();
            DataTable DT = new DataTable();
            oda.Fill(DT);
            connection.Close();
            return DT;
        }

        public void InsertDataIntoTable(string table, string[] args)
        {
            string cmdTableCols = $"SELECT column_name FROM user_tab_cols WHERE table_name=UPPER('{table}')";
            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = cmdTableCols;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            List<string> cols = new List<string>();
            using (OracleDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                    cols.Add(reader.GetString(0));

            var builder = new StringBuilder();
            builder.Append($"insert into {table} (");

            for (int colIndex = 1; colIndex < cols.Count; colIndex++)
                builder.Append($"{cols[colIndex]},");
            builder.Remove(builder.Length - 1, 1);
            builder.Append($") values (");

            foreach (string arg in args)
                builder.Append($"'{arg}',");
            builder.Remove(builder.Length - 1, 1);
            builder.Append(")");
            OracleCommand insertCmd = new OracleCommand(builder.ToString(), connection);
            insertCmd.ExecuteNonQuery();

            MessageBox.Show("Данные успешно внесены!");
            connection.Close();
        }

        public DataTable RefreshDataInGridView(string table)
        {
            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = $"select * from {table}";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            oda.SelectCommand.ExecuteNonQuery();
            DataTable DT = new DataTable();
            oda.Fill(DT);
            connection.Close();
            return DT;
        }

        public void RemoveRowFromTableById(string table, int id)
        {
            var commandString = $"delete from {table} where {table}.id = {id}";
            try
            {
                var connection = new OracleConnection(ConnectionString);
                connection.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = commandString;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
                RefreshDataInGridView(table);
                MessageBox.Show("Удалено!");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка при удалении строки из БД: {e.Message}");
            }
        }
    }
}
