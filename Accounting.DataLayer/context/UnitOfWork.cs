using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.context
{
   public class UnitOfWork:IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _customerRepository;
        public ICustomerRepository customerRepository 
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }

        private GenericRipository<Accounting> _accountingRipository;
        public GenericRipository<Accounting> AcountingRipository 
        {
            get
            {
                if(_accountingRipository == null)
                {
                    _accountingRipository = new GenericRipository<Accounting>(db);
                }
                return _accountingRipository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }

        public  void Save()
        {
            db.SaveChanges();
        }
    }
}
