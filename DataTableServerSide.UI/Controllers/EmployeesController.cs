using DataTableServerSide.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTableServerSide.UI.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData(JqueryDatatableParam param)
        {
            Employee emp=new Employee();

            var employees = emp.GetEmployees(); //This method is returning the IEnumerable employee from database

            if (!string.IsNullOrEmpty(param.sSearch))
            {
                employees = employees.Where(x => x.Name.ToLower().Contains(param.sSearch.ToLower())
                                              || x.Position.ToLower().Contains(param.sSearch.ToLower())
                                              || x.Location.ToLower().Contains(param.sSearch.ToLower())
                                              || x.Salary.ToString().Contains(param.sSearch.ToLower())
                                              || x.Age.ToString().Contains(param.sSearch.ToLower())
                                              || x.IsActive.ToString().Contains(param.sSearch.ToLower())
                                              || x.StartDate.ToString("dd'/'MM'/'yyyy").ToLower().Contains(param.sSearch.ToLower())).ToList();
            }

            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.QueryString["iSortCol_0"]);
            var sortDirection = HttpContext.Request.QueryString["sSortDir_0"];
            if (sortColumnIndex == 3)
            {
                employees = sortDirection == "asc" ? employees.OrderBy(c => c.Age) : employees.OrderByDescending(c => c.Age);
            }
            else if (sortColumnIndex == 4)
            {
                employees = sortDirection == "asc" ? employees.OrderBy(c => c.StartDate) : employees.OrderByDescending(c => c.StartDate);
            }
            else if (sortColumnIndex == 5)
            {
                employees = sortDirection == "asc" ? employees.OrderBy(c => c.Salary) : employees.OrderByDescending(c => c.Salary);
            }
            else if (sortColumnIndex == 6)
            {
                employees = sortDirection == "asc" ? employees.OrderByDescending(c => c.IsActive) : employees.OrderBy(c => c.IsActive);
            }
            else
            {
                Func<Employee, string> orderingFunction = e => sortColumnIndex == 0 ? e.Name : sortColumnIndex == 1 ? e.Position : e.Location;
                employees = sortDirection == "asc" ? employees.OrderBy(orderingFunction) : employees.OrderByDescending(orderingFunction);
            }

            var displayResult = employees.Skip(param.iDisplayStart)
               .Take(param.iDisplayLength).ToList();
            var totalRecords = employees.Count();

            return Json(new
            {
                param.sEcho,
                iTotalRecords = totalRecords,
                iTotalDisplayRecords = totalRecords,
                aaData = displayResult
            }, JsonRequestBehavior.AllowGet);
        }
    }
}