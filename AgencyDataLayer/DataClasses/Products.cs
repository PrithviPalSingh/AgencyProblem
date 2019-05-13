using DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataLayer.DataClasses
{
    public class Products
    {
        public IList<BaseDM> GetProducts()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "agencyproblem.database.windows.net";
            builder.UserID = "********";
            builder.Password = "*******";
            builder.InitialCatalog = "AgencyProblem";
            IList<BaseDM> list = new List<BaseDM>();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {                
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "uspGetProducts";
                command.Connection = connection;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BaseDM bd = new BaseDM();
                        bd.InsuranceCode = reader["Code"].ToString();
                        bd.InsuranceDescription = reader["Description"].ToString();
                        bd.InsuranceDuration = Convert.ToInt32(reader["Duration"]);
                        bd.InsuranceName = reader["Name"].ToString();
                        bd.InsurancePrice = Convert.ToDouble(reader["Price"]);
                        bd.InsuranceType = Convert.ToChar(reader["InsuranceType"]);
                        list.Add(bd);
                    }
                }
            }

            return list;
        }
    }
}
