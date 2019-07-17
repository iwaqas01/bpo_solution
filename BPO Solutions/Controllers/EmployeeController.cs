using BPO_Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BPO_Solutions.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        BPOContext context = null;
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewAllowances()
        {
            using (context = new BPOContext())
            {
                    var obj= context.Employee.ToList();
                ViewBag.employee = obj;

            }
            return View();

        }
        [HttpPost]
        public ActionResult NewAllowances(AllowancesModel All)
        {
            if (ModelState.IsValid)
            {
                using (context = new BPOContext())
                {
                    Allowances all = new Allowances()
                    {
                        Allowance_Name = All.Allowance_Name,
                        Amount = All.Amount,
                        Emp_ID = All.Emp_ID,
                        ID = All.ID
                    };

                    context.Allowances.Add(all);
                    context.SaveChanges();


                    var obj = context.Employee.ToList();
                    ViewBag.employee = obj;
                }
            }

            return View();

        }

        public ActionResult ViewAllowances()
        {
            using (context = new BPOContext())
            {
                var obj = context.Allowances.ToList();
                return View(obj);

            }
        }


    }
}