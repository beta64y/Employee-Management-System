using Employee_Management_System.Context;
using Employee_Management_System.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Employee_Management_System.Models.Employee;
using Employee_Management_System.Services;

namespace Employee_Management_System
{
    public class EmployeeController : Controller
    {
        [HttpGet("Index", Name = "employee-index")]
        public IActionResult Index()
        {
            using DataContext dataContext = new DataContext();

            var model = dataContext.Employees.Where(b => b.IsDeleted == false)
                .Select(b => new ListViewModel(b.Name, b.Surname, b.FatherName, b.Code, b.IsDeleted))
                .ToList();


            return View(model);
        }
        [HttpGet("Add", Name = "employee-add")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost("Add", Name = "employee-add")]
        public IActionResult Add(AddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using DataContext dataContext = new DataContext();

            dataContext.Employees.Add(new Employee
            {
                Name = model.Name,
                Surname = model.Surname,
                FatherName = model.FatherName,
                FIN = model.FIN,
                Email = model.Email,
                Code = CodeCreator.CreateCode()
            });
            dataContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Delete/{Code}", Name = "employee-delete")]
        public ActionResult Delete(string Code)
        {
            using DataContext dataContext = new DataContext();
            var employee = dataContext.Employees.FirstOrDefault(b => b.Code == Code);
            if (employee is null)
            {
                return NotFound();
            }

            employee.IsDeleted = true;
            dataContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    

    [HttpGet("Update/{Code}", Name = "employee-update")]
    public IActionResult Update([FromRoute] string Code)
    {
        using DataContext dataContext = new DataContext();
        var employee = dataContext.Employees.FirstOrDefault(b => b.Code == Code);
        if (employee is null)
        {
            return NotFound();
        }

        return View(new UpdateResponseViewModel
        {
            Name = employee.Name,
            Surname = employee.Surname,
            FatherName = employee.FatherName,
            FIN = employee.FIN,
            Email = employee.Email
        });
    }


    [HttpPost("Update/{Code}", Name = "employee-update")]
    public IActionResult Update([FromRoute] string Code, [FromForm] UpdateRequestViewModel model)
    {
        using DataContext dataContext = new DataContext();
        var employee = dataContext.Employees.FirstOrDefault(b => b.Code == Code);
        if (employee is null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        employee.Name = model.Name;
        employee.Surname = model.Surname;
        employee.FatherName = model.FatherName;
        employee.FIN = model.FIN;
        employee.Email = model.Email;

        dataContext.SaveChanges();
        return RedirectToAction(nameof(Index));
    }




}
       
}
