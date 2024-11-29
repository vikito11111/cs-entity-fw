using _01._db_first_model_demo.Models;

var db = new SoftuniContext();

var employees = db.Employees.Where(x => x.Department.Manager.Department.Name == "Sales")
    .Select(x => new
    {
        Name = x.FirstName + " " + x.LastName,
        DepartmentName = x.Department.Name,
        Manager = x.Manager.FirstName + " " + x.Manager.LastName
    });

foreach (var employee in employees)
{
    Console.WriteLine(employee.Name + " => " + employee.DepartmentName + " => " + employee.Manager);
}