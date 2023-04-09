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
            int employeeAttendence = random.Next(0,2);
            if (employeeAttendence == IS_FULL_TIME)
            {
                Console.WriteLine("fulltime employee attendence is present");
                empHrs = 8;
            }
            else if(employeeAttendence == IS_PART_TIME) 
            {
                Console.WriteLine("Parttime employee attendence is Present");
                empHrs = 4;
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