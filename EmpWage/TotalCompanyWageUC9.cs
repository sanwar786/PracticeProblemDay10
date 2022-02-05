using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay10.EmpWage
{
    internal class TotalCompanyWageUC9
    {
        //Initializing Constant
        private const int FULL_TIME_EMP = 1;
        private const int PART_TIME_EMP = 2;

        //Initializing Variables
        private static int dailyEmpHrs = 0;
        private static int dailyEmpWage = 0;
        private static int totalWage = 0;

        //Declaring Variables
        public readonly string company;
        public readonly string name;
        public readonly int wagePerHours;
        public readonly int dailyHours;
        public readonly int dayPerMonth;
        public readonly int totalHours;

        public EmployeeWage(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours)
        {
            this.company = company;
            this.name = name;
            this.wagePerHours = wagePerHours;
            this.totalHours = totalHours;
            this.dailyHours = dailyHours;
            this.dayPerMonth = dayPerMonth;
            this.totalHours = totalHours;
        }

        //Compute Employ Wage for Multiple Companies Using Procedural Ways (UC8)
        public void ComputeMonthlyWage()
        {
            // local Variable
            int day = 0, hours = 0;
            string chkEmp;

            //Calculating Wages Per Month And Added Total Hours Condition(UC5 & UC6)
            Random randCheck = new Random();
            while (day < dayPerMonth && hours <= totalHours)
            {
                //Check Employ Is Present Or Absent(UC1)          
                int checkAttend = randCheck.Next(0, 3);

                //Solved Using Switch Case(UC4)
                switch (checkAttend)
                {
                    case FULL_TIME_EMP:
                        chkEmp = "Full Time";
                        dailyEmpHrs = dailyHours;
                        break;
                    case PART_TIME_EMP:
                        chkEmp = "Part Time";
                        dailyEmpHrs = dailyHours / 2;
                        break;
                    default:
                        chkEmp = "  Absent  ";
                        dailyEmpHrs = 0;
                        break;
                }

                //Calculate Employ Daily Wage And Part Time Wage (UC2 & UC3)
                dailyEmpWage = wagePerHours * dailyEmpHrs;
                day++;
                hours += dailyEmpHrs;
                totalWage += dailyEmpWage;
                Console.WriteLine("Day: {0} CheckEmployee: {1} Hours: {2} DailyWage: {3}  TotalWage: {4}", day, chkEmp, hours, dailyEmpWage, totalWage);
            }
            Console.WriteLine("Employ Name : {0} \nCompany Name : {1} \nTotal Wage Per Month Is : {2} \nTotal Working Hours : {3} \nTotal Working Day is : {4}", name, company, totalWage, hours, day);
            Console.ReadLine();
        }

        //Saving total wage for each company(UC9)
        public string GetTotalWage()
        {
            return "Company Name : " + company + " \nMonthly Wage Is Rs : " + totalWage;
        }
    }
}
