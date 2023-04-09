namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empWage = 0;
            int isPresent = 1;
            const int EMP_RATE_PER_HR = 20;

            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            //UC1-EMployeeAttendance
            Random random = new Random();
            int employeeAttendence = random.Next(0,3);
            switch (employeeAttendence)
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
            
            //UC2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage is:" + empWage);

        }
    }
}