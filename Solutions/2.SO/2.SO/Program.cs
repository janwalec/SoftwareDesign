// See https://aka.ms/new-console-template for more information

using ReportGenerator;

var db = new EmployeeDB();

// Add some employees
db.AddEmployee(new Employee("Anne", 3000, 14));
db.AddEmployee(new Employee("Berit", 2000, 15));
db.AddEmployee(new Employee("Christel", 1000, 10));

var reportGenerator = new ReportGenerator.ReportGenerator(db);

Console.WriteLine("NAME FIRST");
var nameFirst = new NameFirstPrinter();
reportGenerator.CompileReport(nameFirst);


Console.WriteLine("\n\nSALARY FIRST");
var salaryFirst = new SalaryFirstPrinter();
reportGenerator.CompileReport(salaryFirst);

Console.WriteLine("\n\nAGE FIRST");
var ageFirst = new AgeFirstPrinter();
reportGenerator.CompileReport(ageFirst);