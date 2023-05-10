using EmployeeWageCalculation_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation_Problem
{
    public interface ICompanyEmpWage
    {
        public void addCompanyEmpWage(string companyName, int empRatePerHour, int noOfworkingDays, int maxHours);
        public void computeEmpWage();
        
    }
    public class EmployeeBuilderArray : ICompanyEmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //public int noOfCompany = 0;
        private LinkedList<CompanyEmpWage> companyEmpList;
        private Dictionary<string, CompanyEmpWage> companyEmpWageDict;

        internal LinkedList<CompanyEmpWage> CompanyEmpList { get => companyEmpList; set => companyEmpList = value; }

        public EmployeeBuilderArray()
        {
            this.CompanyEmpList = new LinkedList<CompanyEmpWage>();
            this.companyEmpWageDict = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string companyName, int empRatePerHour, int noOfworkingDays, int maxHours)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, empRatePerHour, noOfworkingDays, maxHours);
            this.CompanyEmpList.AddLast(companyEmpWage);
            this.companyEmpWageDict.Add(companyName, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage company in this.CompanyEmpList)
            {
                company.setTotalEmpWage(this.computeEmpWage(company));
                Console.WriteLine(company.toString());
            }

        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int emphrs = 0, totEmpHrs = 0, totalworkingdays = 0;

            while (totalworkingdays < companyEmpWage.numofworkingdays && emphrs <= companyEmpWage.emprateperhour)
            {
                totalworkingdays++;
                Random random = new Random();
                int employeeAttendance = random.Next(0, 3);
                switch (employeeAttendance)
                {
                    case FULL_TIME:
                        emphrs = 8;
                        break;
                    case PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }

                totEmpHrs += emphrs;
                Console.WriteLine("Days:" + totalworkingdays + " dialyWage:" + emphrs* companyEmpWage.emprateperhour);
            }
            //Console.WriteLine("Days:" + totalworkingdays + " emphrs:" + emphrs);
            return totEmpHrs * companyEmpWage.emprateperhour;
        }



        public int getTotalWage(string company)
        {
            return this.companyEmpWageDict[company].totalWage;
        }

      
        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Employee Wage Computation Program!");
                EmployeeBuilderArray employee = new EmployeeBuilderArray();
                employee.addCompanyEmpWage("TCS", 10, 15, 90);
                employee.addCompanyEmpWage("Infosys", 30, 30, 150);
                employee.addCompanyEmpWage("TechM", 30, 40, 150);
                employee.computeEmpWage();
                

            }
        }
    }
}