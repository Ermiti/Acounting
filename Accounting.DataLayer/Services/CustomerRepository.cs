using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using System.Data.Entity;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        Accounting_DBEntities db;

        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomersById(customerId);
                DeleteCustomer(customer);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return   db.Customers.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();

        }

        public Customers GetCustomersById(int customerId)
        {
            return  db.Customers.Find(customerId);
        }

        public List<ListCustomerViewModel> GetNameCustomer(string Filter = "")
        {
            if(Filter == "")
            {
                return db.Customers.Select(c => new ListCustomerViewModel()
                {
                    FullName = c.FullName
                }).ToList();

            }
            return db.Customers.Where(c => c.FullName.Contains(Filter)).Select(c => new ListCustomerViewModel()
            {
                FullName = c.FullName
            }).ToList();
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                var local = db.Set<Customers>()
                         .Local
                         .FirstOrDefault(f => f.CustomersID == customer.CustomersID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
