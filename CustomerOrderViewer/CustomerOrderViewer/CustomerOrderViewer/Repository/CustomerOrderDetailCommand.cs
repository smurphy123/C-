using CustomerOrderViewer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CustomerOrderViewer.Repository
{
    class CustomerOrderDetailCommand
    {
        private string _connectionString;

        public CustomerOrderDetailCommand(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<CustomerOrderDetailModel> GetLsit()
        {
            List<CustomerOrderDetailModel> customerOrderDetailModels = new List<CustomerOrderDetailModel>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT CustomerOrderId, ItemId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail", connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string firstname = reader["FirstName"].ToString();
                            }
                        }
                    }
                }
            }

            return customerOrderDetailModels;
        }
    }
}
