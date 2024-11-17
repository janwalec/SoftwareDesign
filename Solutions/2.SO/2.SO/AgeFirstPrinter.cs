namespace ReportGenerator;

public class AgeFirstPrinter : Printer
{
    public void Print(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Age: {0}", employee.Age);
            Console.WriteLine("Name: {0}", employee.Name);
            Console.WriteLine("Salary: {0}", employee.Salary);
            Console.WriteLine("------------------");
        }
    }
}