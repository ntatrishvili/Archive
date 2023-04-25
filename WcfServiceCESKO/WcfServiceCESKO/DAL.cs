using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfServiceCESKO
{
    public static class DAL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["CESKO"].ConnectionString;

        public static int AddClient(Client client)
        {
            int result = 0;
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "add_clients";
                    command.Parameters.AddWithValue("@firstName", client.FirstName);
                    command.Parameters.AddWithValue("@lastName", client.LastName);
                    command.Parameters.AddWithValue("@birthDate", client.BirthDate);
                    command.Parameters.AddWithValue("@address", client.Address);
                    command.Parameters.AddWithValue("@personalID", client.PersonalID);
                    command.Parameters.AddWithValue("@pictureBase64", client.PictureBase64);
                    SqlParameter sqlParameter = new SqlParameter("@id", SqlDbType.Int);
                    sqlParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(sqlParameter);
                    connection.Open();
                    command.ExecuteNonQuery();
                    result = int.Parse(sqlParameter.Value.ToString());
                    return result;
                }
            }
        }

        public static bool DeleteClient(string PersonalID)
        {
            bool result = false;
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "delete_clients";
                    command.Parameters.AddWithValue("@personalid", PersonalID);
                    SqlParameter sqlParameter = new SqlParameter("@success", SqlDbType.Bit);
                    sqlParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(sqlParameter);
                    connection.Open();
                    command.ExecuteNonQuery();
                    result = bool.Parse(sqlParameter.Value.ToString());
                    return result;
                }
            }
        }
        public static int UpdateClient(Client client)
        {
            int result = 0;
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "update_clients";
                    command.Parameters.AddWithValue("@firstName", client.FirstName);
                    command.Parameters.AddWithValue("@lastName", client.LastName);
                    command.Parameters.AddWithValue("@birthDate", client.BirthDate);
                    command.Parameters.AddWithValue("@address", client.Address);
                    command.Parameters.AddWithValue("@personalID", client.PersonalID);
                    command.Parameters.AddWithValue("@pictureBase64", client.PictureBase64);
                    SqlParameter sqlParameter = new SqlParameter("@id", SqlDbType.Int);
                    sqlParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(sqlParameter);
                    connection.Open();
                    command.ExecuteNonQuery();
                    result = int.Parse(sqlParameter.Value.ToString());
                    return result;
                }
            }
        }
    }
}