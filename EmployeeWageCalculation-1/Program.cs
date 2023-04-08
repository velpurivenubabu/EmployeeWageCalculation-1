namespace EmployeeWageCalculation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            //UC1-EmployeeAttandenance
            Random random = new Random();
            int empAttandence = random.Next(0, 2);
            if (isPresent == empAttandence)
            {
                Console.WriteLine("employee is prasent");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
            int empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee wage is : " + empWage);
        }
    }
}