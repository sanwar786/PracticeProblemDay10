using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay10.EmpWage
{
    internal class DailyTotalWageUC13
    {
        //Initializing Constant
        private const int FULL_TIME_EMP = 1;
        private const int PART_TIME_EMP = 2;

        //Initializing List
        private List<CompanyEmployWage> companyEmpWageList;
        private List<CompanyEmployWage> empdDailyTotalWageList;

        public EmployeeWageBuilder()
        {
            companyEmpWageList = new List<CompanyEmployWage>();
            empdDailyTotalWageList = new List<CompanyEmployWage>();
        }

        //Ability to manage employee wage of multiple companies using list(UC10 & UC11)
        public void AddCompanyEmpWageToList(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours)
        {
            CompanyEmployWage companyEmpWage = new CompanyEmployWage(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
            companyEmpWageList.Add(companyEmpWage);
        }

        public void IterateEmpWageCompany()
        {
            foreach (CompanyEmployWage companyEmp in companyEmpWageList)
            {
                companyEmp.SetTotalEmployWage(ComputeMonthlyWage(companyEmp));
                Console.WriteLine(companyEmp.CompanyTotalWageToString());
                Console.ReadLine();
            }
        }

        //Compute Employ Wage for Multiple Companies Using Procedural Ways (UC8)
        public int ComputeMonthlyWage(CompanyEmployWage companyEmp)
        {
            // local Variable
            int day = 0, hours = 0, dailyEmpHrs, dailyEmpWage, totalWage = 0;


            //Calculating Wages Per Month And Added Total Hours Condition(UC5 & UC6)
            Random randCheck = new Random();
            while (day < companyEmp.dayPerMonth && hours <= companyEmp.totalHours)
            {
                //Check Employ Is Present Or Absent(UC1)          
                int checkAttend = randCheck.Next(0, 3);

                //Solved Using Switch Case(UC4)
                switch (checkAttend)
                {
                    case FULL_TIME_EMP:
                        dailyEmpHrs = companyEmp.dailyHours;
                        break;
                    case PART_TIME_EMP:
                        dailyEmpHrs = companyEmp.dailyHours / 2;
                        break;
                    default:
                        dailyEmpHrs = 0;
                        break;
                }

                //Calculate Employ Daily Wage And Part Time Wage (UC2 & UC3)
                dailyEmpWage = companyEmp.wagePerHours * dailyEmpHrs;
                day++;
                hours += dailyEmpHrs;
                totalWage += dailyEmpWage;

                //Storing the daily Wage along with total wage(UC13)
                CompanyEmployWage empDailyTotalWage = new CompanyEmployWage(companyEmp.company, dailyEmpWage, totalWage);
                empdDailyTotalWageList.Add(empDailyTotalWage);
            }
            Console.WriteLine("Employ Name : {0} \nCompany Name : {1} \nTotal Wage Per Month Is : {2} \nTotal Working Hours : {3} \nTotal Working Day is : {4}", companyEmp.name, companyEmp.company, totalWage, hours, day);
            Console.ReadLine();
            return totalWage;
        }

        //Method to show daily Wage along with total Wage list(UC13)
        public void ShowDailyAndTotalWage(string companyName)
        {
            var showEmpWage = from dailyTotalEmpWage in empdDailyTotalWageList
                              where dailyTotalEmpWage.company == companyName
                              select dailyTotalEmpWage;

            Console.WriteLine("Showing the dailywage and totalwage of company : " + companyName);
            foreach (var empWage in showEmpWage)
                Console.WriteLine("Daily Wage : " + empWage.dailyWage + " TotalWage is : " + empWage.totalWage);
        }
    }
}
