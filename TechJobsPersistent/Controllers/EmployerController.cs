using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext _context;
        // GET: /<controller>/

        public EmployerController(JobDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {
            List<Employer> employers = _context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();
            return View(addEmployerViewModel);
        }

        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if(ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location,
                };

                _context.Employers.Add(newEmployer);
                _context.SaveChanges();

                return Redirect("/Employer");
            }

            return View("~/Views/Employer/Add.cshtml",addEmployerViewModel);
        }

        public IActionResult About(int id)
        {
            Employer thisEmployer = _context.Employers.Find(id);
            return View(thisEmployer);
        }

        public IActionResult Delete()
        {
            ViewBag.employers = _context.Employers.ToList();

            return Redirect("/Employer");
        }

    }
}

//        public IActionResult Add(AddEventViewModel addEventViewModel)
//{
//    if (ModelState.IsValid)
//    {
//        Event newEvent = new Event
//        {
//            Name = addEventViewModel.Name,
//            Description = addEventViewModel.Description,
//            ContactEmail = addEventViewModel.ContactEmail,
//            Type = addEventViewModel.Type
//        };

//        context.Events.Add(newEvent);
//        context.SaveChanges();

//        return Redirect("/Events");
//    }

//    return View(addEventViewModel);
//}
