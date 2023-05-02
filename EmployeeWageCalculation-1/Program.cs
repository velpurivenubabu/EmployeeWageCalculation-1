using Microsoft.VisualBasic;
using static EmployeeWageCalculation_1.Program.CompanyEmpWage;

namespace EmployeeWageCalculation_1
{
    internal class Program
    {
        public class CompanyEmpWage//creating the employee class
        {

            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;
            public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;

            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public string toString()
            {
                return "Total EmpWage for company : " + this.company + " is : " + this.totalEmpWage;
            }

            public class EmpWageBuilderArray
            {
                public const int IS_PART_TIME = 1;
                public const int IS_FULL_TIME = 2;
                private int numOfCompanies = 0;
                //private CompanyEmpWage[] companyEmpWageArray;
                private List<CompanyEmpWage> list;
                public EmpWageBuilderArray()
                {
                    this.list = new List<CompanyEmpWage>();
                }
                public void addCompanyEmpWage(string company, int empRatePerHour, int numberOfWorkingDays, int maxHoursPerMonth)
                {
                    CompanyEmpWage companyList = new CompanyEmpWage(company, empRatePerHour, numberOfWorkingDays, maxHoursPerMonth);
                    list[numOfCompanies] = companyList;
                    numOfCompanies++;
                }
                public void computeEmpWage()
                {
                    for (int i = 0; i < numOfCompanies; i++)
                    {
                        list[i].setTotalEmpWage(this.computeEmpWage(this.list[i]));
                        Console.WriteLine(this.list[i].toString());
                    }
                }




                private int computeEmpWage(CompanyEmpWage companyEmpWage)//Method
                {
                    int totalWorkingDays = 0;
                    int totalEmpHrs = 0;
                    //int empWage = 0;
                    int empHrs = 0;


                    //Welcome message
                    //UC1-EmployeeAttandenance
                    Random random = new Random();
                    while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalEmpHrs < companyEmpWage.numOfWorkingDays)
                    {
                        totalWorkingDays++;
                        int empAttandence = random.Next(0, 3);
                        switch (empAttandence)
                        {
                            case IS_FULL_TIME:
                                empHrs = 8;
                                break;
                            case IS_PART_TIME:
                                empHrs = 4;
                                break;
                            default:
                                empHrs = 0;
                                break;


                        }
                        totalEmpHrs += empHrs;
                        Console.WriteLine("Days :"+totalWorkingDays +" Emp Hrs :"+ empHrs);  
                    }
                    Console.WriteLine(totalEmpHrs);
                    return totalEmpHrs * companyEmpWage.empRatePerHour;
                }
            }
            
        }
        static void Main(string[] args)
        {
         
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Deloitte", 100, 50, 70);
            empWageBuilder.addCompanyEmpWage("Wipro", 120, 60, 40);
            empWageBuilder.addCompanyEmpWage("TCS", 110,70, 60);
            empWageBuilder.computeEmpWage();
        }
    }
}