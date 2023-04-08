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
            if (IS_FULL_TIME == empAttandence)
            {
                Console.WriteLine("Fulltime employee is prasent");
                empHrs = 8;
            }
            else if (IS_PART_TIME == empAttandence)
            {
                Console.WriteLine("Parttime employee is prasent");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("employee attence is absent");
            }
            int empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee wage is : " + empWage);
        }
    }
}