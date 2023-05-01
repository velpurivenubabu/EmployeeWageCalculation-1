using Microsoft.VisualBasic;

namespace EmployeeWageCalculation_1
{
    internal class Program
    {
       public class EmployeeWageBuilderObject//creating the employee class
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            private string companyName;
            private int empRateHr;
            private  int numberOfWorkingDays;
            private int maxWorkingHours;
            private int empWage;
            public EmployeeWageBuilderObject(string companyName, int empRateHr, int numberOfWorkingDays, int maxWorkingHours)
            {
                this.companyName = companyName;
                this.empRateHr = empRateHr;
                this.numberOfWorkingDays = numberOfWorkingDays;
                this.maxWorkingHours = maxWorkingHours;
                
            }

            public void EmployeeWageCalculation ()//Method
            {
                int day = 1;
                int totalHrs = 0;
               //int empWage = 0;
                int empHrs = 0;
                            
                
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
                    empWage += empWage;
                    day++;
                    totalHrs += empHrs;
                    
                }

                Console.WriteLine("For {0} TotalWage for {1} days and Working Hours {2} hrs is {3}", companyName, (day - 1), totalHrs, empWage);
            }
            public string toString()
            {
                return "Total Emp Wage for company : " + this.companyName + " is : " + this.empWage;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            EmployeeWageBuilderObject deloitte = new EmployeeWageBuilderObject("Deloitte", 100, 23, 60);// Creating the Object ofthe class
            deloitte.EmployeeWageCalculation();
            Console.WriteLine(deloitte.toString());
            EmployeeWageBuilderObject wipro = new EmployeeWageBuilderObject("Wipro", 900, 23, 60);// Creating the Object ofthe class
            wipro.EmployeeWageCalculation();
            Console.WriteLine(wipro.toString());
            EmployeeWageBuilderObject tcs = new EmployeeWageBuilderObject("Wipro", 600, 23, 60);// Creating the Object ofthe class
            tcs.EmployeeWageCalculation();
            Console.WriteLine(tcs.toString());
            
        }
    }
}