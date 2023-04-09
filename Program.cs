namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            //UC1-EMployeeAttendance
            Random random = new Random();
            int employeeAttendence = random.Next(0,2);
            if (employeeAttendence == isPresent) 
            {
                Console.WriteLine("employee attendence is present");
            }
            else
            {
                Console.WriteLine("employee attendence is absent");
            }

        }
    }
}