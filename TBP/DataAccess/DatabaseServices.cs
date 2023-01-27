using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.SqlClient;
using Npgsql;


namespace TBP.DataAccess
{
 
    public static class DatabaseService
    {

        /// <summary>
        /// Connection string for logging in to MSSQL database
        /// </summary>
        private static string connectionString ="Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=admin;";


        /// <summary>
        /// new Sql Connection for establishing connection with Db
        /// </summary>
        private static NpgsqlConnection connection { get; set; }

        /// <summary>
        /// Method that opens the connection to database
        /// </summary>
        public static void Connect()
        {

            connection = new NpgsqlConnection(connectionString);
            connection.Open();

        }

        /// <summary>
        /// Disconnects sqlconnection
        /// </summary>
        public static void Disconnect()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Executes NonQuery like insert, update and alter
        /// </summary>
        public static int ExecuteNonQuery(string sqlQuery)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
            return command.ExecuteNonQuery();
        }


        /// <summary>
        /// Gets sql datareader with given query
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns>Reader object</returns>
        public static IDataReader GetDataReader(string sqlQuery)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
            return command.ExecuteReader();
        }

    }
}
