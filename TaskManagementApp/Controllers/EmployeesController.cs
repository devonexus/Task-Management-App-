using DevExpress.Web.Mvc;
using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaskManagementApp.Models;
using TaskManagementApp.Service.Services;

namespace TaskManagementApp.Controllers
{
    public class EmployeesController : Controller
    {
        /// <summary>
        /// Inject or provide services here
        /// </summary>

        private readonly IEmployeeService employeeService;
        private readonly IUnitOfWorkAsync uow;
        public EmployeesController(IEmployeeService employeeService,
            IUnitOfWorkAsync uow) {
           this.employeeService = employeeService;
            this.uow = uow;
        }

        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }




        //TaskDbEntities db = new TaskManagementApp.Models.TaskDb();

        [ValidateInput(false)]
        public ActionResult EmployeesPartial()
        {
            //var model = db.employees;
            return PartialView("_EmployeesPartial", employeeService.GetEmployee());
        }

        [HttpPost, ValidateInput(false)]
        public async Task<ActionResult> EmployeesPartialAddNew(employee item)
        {
            if (ModelState.IsValid)
            {
                try
                {                   
                    employeeService.Insert(item);
                    await uow.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_EmployeesPartial", employeeService.GetEmployee());
        }
        [HttpPost, ValidateInput(false)]
        public async Task<ActionResult> EmployeesPartialUpdate(employee item)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employeeService.Update(item);
                    await uow.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_EmployeesPartial", employeeService.GetEmployee());
        }
        [HttpPost, ValidateInput(false)]
        public async Task<ActionResult> EmployeesPartialDelete(int? employee_id)
        {
           
            if (employee_id != null)
            {
                try
                {
                    employeeService.Delete(employee_id);
                    await uow.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_EmployeesPartial", employeeService.GetEmployee());
        }
    }
}