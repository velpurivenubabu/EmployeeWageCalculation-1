namespace EmployeeWageCalculation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int isPresent = 1;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            //UC1-EmployeeAttandenance
            Random random = new Random();
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
            int empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee wage is : " + empWage);
        }
    }
}