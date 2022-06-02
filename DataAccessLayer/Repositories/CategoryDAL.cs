using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryDAL : ICategoryDAL
    {
        Context c = new Context();
        public void Delete(Category p)
        {
            c.Categories.Remove(p);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
            //TODO !!!
        }

        public List<Category> GetList()
        {
            return c.Categories.ToList();
        }

        public void Insert(Category p)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            throw new NotImplementedException();
        }
    }
}
