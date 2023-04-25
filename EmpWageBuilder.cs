using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmpWageBuilder
    {
        public CompanyDetails[] companies;
        public int numbofcompanies = 0;

        public EmpWageBuilder()
        {
            companies = new CompanyDetails[5];  
        }
        public void AddCompanies(string companyName, int empRatePerHr, int numOfWorkingDays, int maxWorkingHrs)
        {
            CompanyDetails company = new CompanyDetails(companyName,empRatePerHr,numOfWorkingDays,maxWorkingHrs);
            companies[numbofcompanies] = company;
            numbofcompanies++;
        }
        public void FetchCompanyDetailsFromArray()
        {
            for (int i=0; i<companies.Length; i++) 
            {
                if (companies[i]!=null)
                {
                    int totalWage = CalculateEmpWage(companies[i]);
                    companies[i].SetTotalWage(totalWage);
                }
            }
        }
        public static int CalculateEmpWage(CompanyDetails companyDetails)
        {

            int empHrs = 0;
            int day = 1;
            int totalHrs = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empWage = 0;
            int totalWage = 0;
            //const int EMP_RATE_PER_HR = 20;
            //const int NUMBER_OF_WORKING_DAYS = 20;
            //const int MAX_WORKING_HRS = 100;
            
            //UC1-EMployeeAttendance
            Random random = new Random();
            while (day <= companyDetails.numbOfWorkingDays && totalHrs < companyDetails.maxWorkingHrs)
            {
                int employeeAttendence = random.Next(0, 3);
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
                empWage = companyDetails.empRatePerHr * empHrs;
                //Console.WriteLine("Employee wage for day {0} and {1}hrs is:{2}", day, empHrs, empWage);
                day++;
                totalHrs += empHrs;
                totalWage += empWage;
            }
            Console.WriteLine("TotalWage for {0} {1} days and {2} hrs is:{3}", companyDetails.companyName, (day - 1), totalHrs, totalWage);
            return totalWage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem ");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanies("Deloitte", 40, 23, 60);
            empWageBuilder.AddCompanies("Microsoft", 50, 26, 70);
            empWageBuilder.AddCompanies("Infosys", 70, 33, 65);
            empWageBuilder.FetchCompanyDetailsFromArray();
            Console.ReadLine();
        }

    }
   
}