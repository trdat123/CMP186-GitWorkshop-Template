using System;

namespace SalaryCalculator
{
    public class EmployeeService
    {
        private const decimal BASIC_SALARY = 10000000;

        public static decimal CalculateSalary(EmployeeType employeeType, int years)
        {
            if (years < 0)
            {
                throw new ArgumentException("Years of experience is not valid");
            }

            decimal factor = 0;
            
            switch(employeeType) 
            {
              case employeeType.Engineer:
                factor = 1;
                break;
              case employeeType.SeniorEngineer:
                factor = 2.0;
                break;
              case employeeType.Manager:
                factor = 2.0;
                break;
              case employeeType.SeniorManager:
                factor = 3;
                break;
              case employeeType.Expert:
                factor = 3;
                break;
              default:
                break;
            }

            var salary = BASIC_SALARY * years * factor;

            return salary;
        }
    }
}
