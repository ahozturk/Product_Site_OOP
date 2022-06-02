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
    public class ProductDAL : IProductDAL
    {
        Context c = new Context();
        public void Delete(Product p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public Product GetById(int id)
        {
            return c.Products.Find(id);
            //TODO !!!
        }

        public List<Product> GetList()
        {
            return c.Products.ToList();
        }

        public void Insert(Product p)
        {
            c.Products.Add(p);
            c.SaveChanges();
        }

        public void Update(Product p)
        {
            c.Products.Update(p);
            c.SaveChanges();
        }
    }
}
