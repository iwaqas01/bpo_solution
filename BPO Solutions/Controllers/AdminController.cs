using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BPO_Solutions.Models;

namespace BPO_Solutions.Controllers
{
    [Authorize]

    public class AdminController : Controller
    {
        BPOContext context = null;
        bool ismodel = true;
        public AdminController()
        {

        }
        public ActionResult index()
        {
            AdminDashBoardModel adbm = new AdminDashBoardModel();
            using (context = new BPOContext())
            {
                int totalemployee = adbm.NewUsers = context.Employee.Count();
                adbm.leads = context.Leads.Count();
                adbm.Products = context.Products.Count();
                adbm.expense = context.Expenses.Count();
                adbm.salariespadithismonth = ((context.Salaries.ToList().Where(x => x.Date.Value.Month == DateTime.Now.Month).Count()) * 100) / totalemployee;
                adbm.salariespadilastmonth = ((context.Salaries.ToList().Where(x => x.Date.Value.Month == DateTime.Now.AddMonths(-1).Month).Count()) * 100) / totalemployee;
                var obj = adbm._recentLeads = context.Leads.OrderByDescending(x => x.ID).Take(3).ToList();
                adbm._last3leads = (from t1 in obj
                                    join t2 in context.Employee on t1.Emp_ID equals t2.ID
                                    select new LeadJoinModel()
                                    {
                                        No_Of_Leads = t1.No_Of_Leads.Value,
                                        Emp_Name = t2.Emp_Name

                                    }).ToList();
                adbm._employees = context.Employee.OrderByDescending(x => x.ID).Take(5).ToList();

                adbm.totalexpenselastmonth = context.Expenses.ToList().Where(x => x.Date.Value.Month == DateTime.Now.AddMonths(-1).Month).Select(x => x.Amount.Value).Sum();
                adbm.totalexpensethismonth = context.Expenses.ToList().Where(x => x.Date.Value.Month == DateTime.Now.Month).Select(x => x.Amount.Value).Sum();


                return View(adbm);

            }

        }







        public ActionResult NewEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewEmployee(EmployeeModel EMP)
        {
            if(ismodel)
            {
                using (context = new BPOContext())
                {
                    Employee emp = new Employee()
                    {
                        Shift = EMP.Shift,
                        CellNo = EMP.CellNo,
                        Emp_Name = EMP.Emp_Name,
                        FatherName = EMP.FatherName,
                        ID = EMP.ID,
                    };

                    context.Employee.Add(emp);
                    context.SaveChanges();
                }
            }
            return View();
        }


        public ActionResult ViewEmployee()
        {
            using (context = new BPOContext())
            {
                var obj = context.Employee.ToList();
                return View(obj);

            }
        }

        public ActionResult NewDiabetic_PatientRecord()
        {
            using (context = new BPOContext())
            {
               
                return View();

            }
        }
        [HttpPost]
        public ActionResult NewDiabetic_PatientRecord(Diabetic_PatientsModel DBP)
        {
            if(ismodel)
            {
                using (context = new BPOContext())
                {


                    Diabetic_Patients dbp = new Diabetic_Patients()
                    {
                        First_Name = DBP.First_Name,
                        Address = DBP.Address,
                        City_State = DBP.City_State,
                        Diabetes_Type = DBP.Diabetes_Type,
                        DOB = DBP.DOB,
                        Health_Insurance_ID = DBP.Health_Insurance_ID,
                        ID = DBP.ID,
                        Last_Name = DBP.Last_Name,
                        Phone_No = DBP.Phone_No,
                        Status = DBP.Status,
                        Zipcode = DBP.Zipcode
                    };

                    context.Diabetic_Patients.Add(dbp);
                    context.SaveChanges();


                }

            }
            return View();

        }

        public ActionResult ViewDiabetic_PatientRecord()
        {
            using (context = new BPOContext())
            {
                var obj = context.Diabetic_Patients.ToList();
                return View(obj);

            }
        }


        public ActionResult NewEquipment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewEquipment(EquipmentsModel EQP)
        {
            if(ismodel)
            {
                using (context = new BPOContext())

                {

                    Equipments eqp = new Equipments()
                    {
                        Equipment_Name = EQP.Equipment_Name,
                        ID = EQP.ID,
                        Quantity = EQP.Quantity
                    };
                    context.Equipments.Add(eqp);
                    context.SaveChanges();

            }
            }
            return View();
        }


        public ActionResult ViewEquipment()
        {
            using (context = new BPOContext())

            {
                var obj = context.Equipments.ToList();
                return View(obj);

            }

        }


        public ActionResult NewExpenses()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewExpenses(ExpensesModel EXP)
        {
            if(ismodel)
            {
                using (context = new BPOContext())

                {

                    Expenses exp = new Expenses()
                    {
                        Expense_Name = EXP.Expense_Name,
                        Amount = EXP.Amount,
                        ID = EXP.ID,
                        Date = EXP.Date
                    };
                    context.Expenses.Add(exp);
                    context.SaveChanges();

            }
            }
            return View();
        }

        public ActionResult ViewExpenses()
        {

            using (context = new BPOContext())
            {
                var obj = context.Expenses.ToList();
                return View(obj);


            }
        }

        public ActionResult NewLead()
        {
            using (context = new BPOContext())
            {
                var obj = context.Employee.ToList();
                ViewBag.employee = obj;

            }
            return View();
        }

        [HttpPost]
        public ActionResult NewLead(LeadsModel LED)
        {
            if(ismodel)
            {
                using (context = new BPOContext())

                {

                    Leads led = new Leads()
                    {
                        Emp_ID = LED.Emp_ID,
                        ID = LED.ID,
                        No_Of_Leads = LED.No_Of_Leads
                    };
                    context.Leads.Add(led);
                    context.SaveChanges();

            }
            }
            return View();
        }
        public ActionResult ViewLead()
        {
            using (context = new BPOContext())
            {
                var obj=context.Leads.ToList();
                return View(obj);

            }

        }


        public ActionResult newPatient()
        {

            return View();
        }

        [HttpPost]
        public ActionResult newPatient(PatientModel Pat)
        {
            if(ismodel)
            {

                using (context = new BPOContext())

                {

                    Patient pat = new Patient()
                    {
                        Address = Pat.Address,
                        Area_Of_Pain = Pat.Area_Of_Pain,
                        City_State = Pat.City_State,
                        DOB = Pat.DOB,
                        First_Name = Pat.First_Name,
                        Health_Insurance_Id = Pat.Health_Insurance_Id,
                        ID = Pat.ID,
                        Last_Name = Pat.Last_Name,
                        Phone_no = Pat.Phone_no,
                        Status = Pat.Status,
                        Zipcode = Pat.Zipcode
                    };

                    context.Patient.Add(pat);
                    context.SaveChanges();

            }
            }
            return View();


        }

        public ActionResult ViewPatient()
        {
            using (context = new BPOContext())
            {

                var obj = context.Patient.ToList();
                return View(obj);


            }

        }



        public ActionResult newProducts()
        {
            return View();

        }
        [HttpPost]
        public ActionResult newProducts(ProductsModel PRO)
        {

            if(ismodel)
            {
                using (context = new BPOContext())

                {

                    Products pro = new Products()
                    {
                        ID = PRO.ID,
                        Product_Description = PRO.Product_Description,
                        Product_Name = PRO.Product_Name
                    };
                    context.Products.Add(pro);
                    context.SaveChanges();

            }
            }
            return View();

        }

        public ActionResult ViewProducts()
        {
            using (context = new BPOContext())
            {
                var obj = context.Products.ToList();
                return View(obj);

            }


        }

        public ActionResult viewrole()
        {
            using (context = new BPOContext())
            {
                var obj = context.Role.ToList();
                return View(obj);

            }


        }

        public ActionResult newrole()
        {
            using (context = new BPOContext())
            {
                var obj = context.Employee.ToList();
                ViewBag.employee = obj;

            }
            return View();

        }


        [HttpPost]
        public ActionResult newrole(RoleModel Rl)
        {
            if(ismodel)
            {
                using (context = new BPOContext())

                {

                    Role rl = new Role()
                    {
                        ID = Rl.ID,
                        Role1 = Rl.Role1,
                        User_ID = Rl.User_ID
                    };
                    context.Role.Add(rl);
                    context.SaveChanges();

            }
            }
            var obj = context.Employee.ToList();
            ViewBag.employee = obj;

            return View();

        }



        public ActionResult viewSalaries()
        {
            using (context = new BPOContext())
            {
                var obj = context.Salaries.ToList();
                return View(obj);

            }


        }

        public ActionResult newSalaries()
        {
            using (context = new BPOContext())
            {
                var obj = context.Employee.ToList();
                ViewBag.employee = obj;

            }
            return View();
        }
           [HttpPost]
        public ActionResult newSalaries(SalariesModel SAL)
        {
            if(ismodel)
            {
                using (context = new BPOContext())

                {

                    Salaries sal = new Salaries()
                    {
                        Date = SAL.Date,
                        Emp_ID = SAL.Emp_ID,
                        ID = SAL.ID,
                        Salary = SAL.Salary
                    };
                    var obj = context.Employee.ToList();
                    ViewBag.employee = obj;
                }

            }
            return View();
        }




    }
}