using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> 
    {
        void TInsert(T p);
        void TRemove(T p);
        void TUpdate(T p);
        List<T> TGetList();
        T TGetById(int id);
    }
}
