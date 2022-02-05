using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay10
{
    internal class Program
    {
        private static string DMart;
        private static object Abc;
        private static object Xyz;

        static void Main(string[] args)
        {
            EmpWage.EmpPresentUC1.FindEmpPresent();
            EmpWage.CalculatingEmpWageUC2.FindEmpWage();
            EmpWage.PartTimeEmpWageUC3.FindPartTimeEmpWage();
            EmpWage.EmpWageSwitchUC4.FindEmpWageSwitch();
            EmpWage.EmpWageMonthUC5.FindEmpWageForMonth();
            EmpWage.EmpWageDayHourUC6.FindWageofWorkingDays();
            EmpWage.ComputeEmpWageUC7.ComputeEmpWage();
            EmpWage.CompanyWageUC8.computeEmpWage(DMart, 20, 2, 10);
            EmpWage.TotalCompanyWageUC9.EmployeeWage(Abc, Xyz, 1, 2, 3, 2)
           
        }
    }
}
