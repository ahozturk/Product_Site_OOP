using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : GenericManager<Customer>, ICustomerService
    {
        ICustomerDAL _generic;
        public CustomerManager(IGenericDAL<Customer> genericDAL) : base(genericDAL)
        {
            _generic = (ICustomerDAL)genericDAL;
        }

        public List<Customer> GetAllWithJob()
        {
            return _generic.GetListWithJob();
        }
    }
}
