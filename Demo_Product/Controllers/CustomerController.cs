using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager manager = new CustomerManager(new EF_CustomerDAL());
        JobManager jobManager = new JobManager(new EF_JobDAL());

        public IActionResult Index()
        {
            return View(manager.GetAllWithJob());
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                          select new SelectListItem
                                          {
                                              Text = x.Name,
                                              Value = x.JobId.ToString()
                                          }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            manager.TInsert(p);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var values = (from x in jobManager.TGetList()
                          select new SelectListItem
                          {
                              Text = x.Name,
                              Value = x.JobId.ToString()
                          }).ToList();
            ViewBag.v = values;
            var customer = manager.TGetById(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            
            manager.TUpdate(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCustomer(int id)
        {
            var customer = manager.TGetById(id);
            manager.TRemove(customer);
            return RedirectToAction("Index");
        }
    }
}
