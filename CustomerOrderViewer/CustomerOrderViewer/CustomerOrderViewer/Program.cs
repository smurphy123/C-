using CustomerOrderViewer.Models;
using CustomerOrderViewer.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CustomerOrderViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOrderDetailCommand customerOrderDetailCommand = new CustomerOrderDetailCommand(@"Data Source=localhost;Initial Catalog=CustomerOrderViewer;Integrated Security=True");

            IList<CustomerOrderDetailModel> customerOrderDetailModels = customerOrderDetailCommand.GetLsit();
        }
    }
}
