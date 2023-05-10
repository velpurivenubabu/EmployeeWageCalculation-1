using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation_1
{
    public class CompanyEmpWage
    {
        public string company;
        public int numofworkingdays;
        public int emprateperhour;
        public int maxHoursPerMonth;
        public int maxWorkingDays;
        public int totalWage;

        public CompanyEmpWage(string company, int emprateperhour, int numofworkingdays, int maxHoursPerMonth)
        {
            this.company = company;
            this.numofworkingdays = numofworkingdays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.emprateperhour = emprateperhour;
        }
        public void setTotalEmpWage(int totalWage)
        {
            this.totalWage = totalWage;

        }

        public string toString()
        {
            return "Total Employee Wage for Company  " + this.company + " is " + this.totalWage;
        }
    }
}
