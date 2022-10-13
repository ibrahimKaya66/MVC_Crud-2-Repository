
using MVC_Crud.Business.Repository.GenericRepositoryManager;
using MVC_Crud.Models;
using MVC_Crud.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Crud.Controllers
{
    public class EmployeeController : Controller
    {
        CrudDbContext db = new CrudDbContext();
        // GET: Employee
        GenericRepository<Employee> genericRepository = new GenericRepository<Employee>();
        public ActionResult Index()
        {
            List<Employee> employees = genericRepository.Get_List();
            return View(employees);
        }
        [HttpGet]
        public ActionResult Save()//Create di
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Employee employee)//Create
        {
            genericRepository.Add(employee);
            return RedirectToAction("Index", "Employee");
        }

        public ActionResult Update(int id)
        {
            var model = db.employees.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("Update", model);
        }

        [HttpPost]
        public ActionResult Update(Employee employee)//Create
        {
            genericRepository.Update(employee);
            return RedirectToAction("Index", "Employee");
        }
        public ActionResult Delete(int id)
        {
            genericRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}