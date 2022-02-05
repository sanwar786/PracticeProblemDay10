using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay10
{
    internal class CompanyWageUC10
    {
        //Declaring Variables
        public readonly string company;
        public readonly string name;
        public readonly int wagePerHours;
        public readonly int dailyHours;
        public readonly int dayPerMonth;
        public readonly int totalHours;
        public int totalEmpWage;

        public CompanyEmployWage(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours)
        {
            this.company = company;
            this.name = name;
            this.wagePerHours = wagePerHours;
            this.totalHours = totalHours;
            this.dailyHours = dailyHours;
            this.dayPerMonth = dayPerMonth;
            this.totalHours = totalHours;
        }

        //Saving total wage for each company(UC9)
        public void SetTotalEmployWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        //Returning company name with total wage of the company
        public string CompanyTotalWageToString()
        {
            return "Company Name : " + this.company + " \nMonthly Wage Is Rs : " + this.totalEmpWage;
        }

    }
}
