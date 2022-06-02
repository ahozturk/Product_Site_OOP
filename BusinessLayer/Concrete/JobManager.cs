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
    public class JobManager : GenericManager<Job>, IJobService
    {
        public JobManager(IGenericDAL<Job> genericDAL) : base(genericDAL)
        {
        }
    }
}
