using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class CompanyDetails
    {
        public string companyName;
        public int empRatePerHr, numbOfWorkingDays, maxWorkingHrs, totalWage;

        public CompanyDetails(string companyName, int empRatePerHr, int numOfWorkingDays, int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.empRatePerHr = empRatePerHr;
            this.numbOfWorkingDays = numOfWorkingDays;  
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
    }
}
