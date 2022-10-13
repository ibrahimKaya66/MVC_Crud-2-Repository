
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
    public class DepartmentController : Controller
    {
        GenericRepository<Department> genericRepository = new GenericRepository<Department>();
        CrudDbContext db = new CrudDbContext();
        // GET: Department
        public ActionResult Index()
        {
            List<Department> departments = genericRepository.Get_List();
            return View(departments);
        }

        [HttpGet]
        public ActionResult Save()//Create di
        {
            return View("Save");
        }

        [HttpPost]
        public ActionResult Save(Department department)//Create
        {
            genericRepository.Add(department);
            return RedirectToAction("Index","Department");
        }

        public ActionResult Update(int id)
        {
            var model = db.departments.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("Update",model);
        }

        [HttpPost]
        public ActionResult Update(Department department)//Update
        {
            genericRepository.Update(department);
            return RedirectToAction("Index", "Department");
        }
        public ActionResult Delete(int id)
        {
            genericRepository.Delete(id);
            return RedirectToAction("Index", "Department");
        }
    }
}