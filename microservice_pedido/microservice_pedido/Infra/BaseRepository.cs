using System;
using System.Data;
using System.Data.SqlClient;

namespace microservice_pedido.Infra
{
    public class BaseRepository
    {
        protected string ConnectionString => "Data Source=(localdb)\\v11.0;Initial Catalog=microservice_pedido;Integrated Security=True";

        private readonly SqlConnection _connection;
        private SqlCommand Command { get; set; }

        public BaseRepository()
        {
            _connection = Connect();
        }

        private SqlConnection Connect()
        {
            var connection = new SqlConnection(ConnectionString);
            if (connection.State == ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        protected void ExecuteProcedure(Enum procedureName)
        {
            Command = new SqlCommand(procedureName.ToString(), _connection) { CommandType = CommandType.StoredProcedure };
        }

        protected void AddParameter(string parameter, object value)
        {
            Command.Parameters.Add(new SqlParameter(parameter, value ?? DBNull.Value));
        }

        protected void ExecuteNonQuery()
        {
            Command.ExecuteNonQuery();
        }

        protected SqlDataReader ExecuteReader()
        {
            return Command.ExecuteReader();
        }
    }
}