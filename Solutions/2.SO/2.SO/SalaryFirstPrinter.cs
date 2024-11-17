namespace ReportGenerator;

public class SalaryFirstPrinter : Printer
{
    public void Print(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Salary: {0}", employee.Salary);
            Console.WriteLine("Name: {0}", employee.Name);
            Console.WriteLine("Age: {0}", employee.Age);
            Console.WriteLine("------------------");
        }
    }
}