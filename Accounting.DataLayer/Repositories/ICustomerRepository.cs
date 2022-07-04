using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Repositories
{
   public interface ICustomerRepository
   {
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<Customers> GetAllCustomers();
        List<ListCustomerViewModel> GetNameCustomer(string Filter = "");
        Customers GetCustomersById(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
       
            
    }
}
