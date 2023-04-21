using Microsoft.VisualBasic;

namespace EmployeeWageCalculation_1
{
    internal class Program
    {
        class EmployeeWage//creating the employee class
        {
            
            public void EmployeeWageCalculation(string companyName, int empRateHr, int numberOfWorkingDays,int maxWorkingHours)//Method
            {
                int day = 1;
                int totalHrs = 0;
                int empWage = 0;
                int empHrs = 0;
                const int IS_FULL_TIME = 1;
                const int IS_PART_TIME = 2;              
                int total_Wage = 0;
                //Welcome message
                //UC1-EmployeeAttandenance
                Random random = new Random();
                while (day <= numberOfWorkingDays && totalHrs < maxWorkingHours)
                {
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
                    empWage = empRateHr * empHrs;
                   // Console.WriteLine("Employee wage for day {0} and  {1} hrs is :{2} ", day, empHrs, empWage);
                    total_Wage += empWage;
                    day++;
                    totalHrs += empHrs;
                }

                Console.WriteLine("For {0} TotalWage for {1} days and {2} hrs is {3}", companyName,(day - 1), totalHrs, total_Wage);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            EmployeeWage EmployeeObj= new EmployeeWage();// Creating the Object ofthe class
            EmployeeObj.EmployeeWageCalculation("Deloitte",40,23,60);//Calling The Class method through EmployeeObj
            EmployeeObj.EmployeeWageCalculation("Wipro", 30, 25, 80);
            EmployeeObj.EmployeeWageCalculation("Infosis", 20, 35, 70);
            EmployeeObj.EmployeeWageCalculation("TCS", 40, 15, 50);
        }
    }
}