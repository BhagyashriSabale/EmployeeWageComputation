namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int isPresent = 1;
            const int EMP_RATE_PER_HR = 20;
            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            //UC1-EMployeeAttendance
            Random random = new Random();
            int employeeAttendence = random.Next(0,2);
            if (employeeAttendence == isPresent)
            {
                Console.WriteLine("employee attendence is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee attendence is absent");

            }
            //UC2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage is:" + empWage);

        }
    }
}