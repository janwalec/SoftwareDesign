using System;
using System.Collections.Generic;

namespace ReportGenerator
{

    internal class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;
        
        public ReportGenerator(EmployeeDB employeeDb)
        {
            this._employeeDb = employeeDb;
        }

        public void CompileReport(Printer printer)
        {
            printer.Print(this._employeeDb.GetEmployees());
        }
        
       
        
    }
}