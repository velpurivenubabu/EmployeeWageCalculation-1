namespace EmployeeWageCalculation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            //UC1-EmployeeAttandenance
            Random random = new Random();
            int empAttandence = random.Next(0, 2);
            if (isPresent == empAttandence)
            {
                Console.WriteLine("employee is prasent");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}