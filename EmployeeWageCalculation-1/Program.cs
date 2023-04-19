using Microsoft.VisualBasic;

namespace EmployeeWageCalculation_1
{
    internal class Program
    {
        class EmployeeWage//creating the employee class
        {
            public void EmployeeWageCalculation()//Method
            {
                int day = 1;
                int totalHrs = 0;
                int empWage = 0;
                int empHrs = 0;
                const int IS_FULL_TIME = 1;
                const int IS_PART_TIME = 2;
                const int EMP_RATE_PER_HOUR = 20;
                int NUMBER_OF_WORKING_DAYS = 20;
                const int MAX_WORKING_HRS = 100;
                int total_Wage = 0;
                //Welcome message
                Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
                //UC1-EmployeeAttandenance
                Random random = new Random();
                while (day <= NUMBER_OF_WORKING_DAYS && totalHrs < MAX_WORKING_HRS)
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
                    empWage = EMP_RATE_PER_HOUR * empHrs;
                    Console.WriteLine("Employee wage for day {0} and  {1} hrs is :{2} ", day, empHrs, empWage);
                    total_Wage += empWage;
                    day++;
                    totalHrs += empHrs;
                }

                Console.WriteLine("TotalWage for {0} days and {1} hrs is {2}", (day - 1), totalHrs, total_Wage);
            }
        }
        static void Main(string[] args)
        {
            EmployeeWage EmployeeObj= new EmployeeWage();// Creating the Object ofthe class
            EmployeeObj.EmployeeWageCalculation();//Calling The Class method through EmployeeObj

        }
    }
}