namespace ReportGenerator;

public class NameFirstPrinter : Printer
{
    public void Print(List<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Name: {0}", employee.Name);
            Console.WriteLine("Salary: {0}", employee.Salary);
            Console.WriteLine("Age: {0}", employee.Age);
            
            Console.WriteLine("------------------");
        }
    }
}