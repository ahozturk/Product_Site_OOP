using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        IGenericDAL<T> _genericDAL;
        public GenericManager(IGenericDAL<T> genericDAL)
        {
            _genericDAL = genericDAL;
        }

        public T TGetById(int id)
        {
            return _genericDAL.GetById(id);
        }

        public List<T> TGetList()
        {
            return _genericDAL.GetList();
        }

        public void TInsert(T p)
        {
            _genericDAL.Insert(p);
        }

        public void TRemove(T p)
        {
            _genericDAL.Delete(p);
        }

        public void TUpdate(T p)
        {
            _genericDAL.Update(p);
        }
    }
}
