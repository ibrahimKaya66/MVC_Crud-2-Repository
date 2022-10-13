using MVC_Crud.Models;
using MVC_Crud.Data.Entities;
using MVC_Crud.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Crud.Business.Repository.GenericRepositoryManager;

namespace MVC_Crud.Controllers
{
    
    public class LoginController : Controller
    {
        CrudDbContext db = new CrudDbContext();
        GenericRepository<Users> genericRepository = new GenericRepository<Users>();
        // GET: Login
        public ActionResult Index()
        {
            List<Users> users = genericRepository.Get_List();
            return View(users);
        }

        public ActionResult Login()//HttpGet
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Users users)//HttpGet
        {
            var u = db.Users.FirstOrDefault(x => x.Username == users.Username && x.Pass == users.Pass);
            if (u != null)
                return RedirectToAction("Index", "Login");
            else
                return View("Login");
        }

        public ActionResult Save()//HttpGet
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Users users)//HttpGet
        {
            genericRepository.Add(users);
            return RedirectToAction("Login","Login");
        }

        public ActionResult Update(int id)//HttpGet
        {
            var model = db.Users.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("Update", model);
        }

        [HttpPost]
        public ActionResult Update(Users users)//HttpGet
        {
            genericRepository.Update(users);
            return RedirectToAction("Login", "Login");
        }

        public ActionResult Delete(int id)//HttpGet
        {
            genericRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}