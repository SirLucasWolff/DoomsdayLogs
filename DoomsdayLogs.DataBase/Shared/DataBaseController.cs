using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DoomsdayLogs.DataBase.Shared
{
    public delegate T ConvertToDelegate<T>(IDataReader reader);
    public static class DataBaseController
    {
        static Connection connection = new Connection();

        static SqlCommand cmd = new SqlCommand();

        public static void DataBase(string commandText, Dictionary<string, object>? parameters = null)
        {
            cmd.Connection = connection.SqlServerConnection();

            cmd.CommandText = commandText;
            cmd.Connection = connection.SqlServerConnection();
            cmd.SetParameters(parameters);

            cmd.ExecuteNonQuery();

            connection.SqlServerConnection().Close();
        }

        public class Connection
        {
            public SqlConnection SqlServerConnection()
            {
                SqlConnection? cnn;

                cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString());

                cnn.Open();

                return cnn;
            }
        }

        private static void SetParameters(this IDbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                IDataParameter dbParameter = command.CreateParameter();

                dbParameter.ParameterName = name;
                dbParameter.Value = value;

                command.Parameters.Add(dbParameter);
            }
        }

        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }
    }
}