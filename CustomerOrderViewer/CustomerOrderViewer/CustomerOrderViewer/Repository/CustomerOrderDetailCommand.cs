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

            }

            return customerOrderDetailModels;
        }
    }
}
