namespace EmployeeWageCalculation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            int empWage = 0;
            int empHrs = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int NUMBER_OF_WORKING_DAYS = 20;
            int total_Wage = 0;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            //UC1-EmployeeAttandenance
            Random random = new Random();
            for (day = 1; day <= NUMBER_OF_WORKING_DAYS; day++)
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
                Console.WriteLine("Employee wage for day {0} is {1}", day ,empWage );
                total_Wage += empWage;
            }
           
            Console.WriteLine("Employee wage for 20 days is : " + total_Wage);
        }
    }
}