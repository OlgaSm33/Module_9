using static Module_9_7.Program;

namespace Module_9_7
{
    public class Program
    {
        public delegate bool EligibleToPromotion(Employee EmployeePromotion);
        static void Main(string[] args)
        {
            Employee empl1 = new Employee()
            {
                Id = 55,
                Name = "sdffsd",
                Experience = 5,
                Salary = 10000,

            };

            Employee empl2 = new Employee()
            {
                Id = 56,
                Name = "sdsdfsffsd",
                Experience = 5,
                Salary = 100010,

            };

            Employee empl3 = new Employee()
            {
                Id = 57,
                Name = "sdsdfsfADADDAfsd",
                Experience = 5,
                Salary = 1000199990,

            };

            List<Employee> listEmployees = new List<Employee>() { empl1, empl2, empl3 };
            EligibleToPromotion eligibleToPromotion = Promote;
            Employee.PromoteEmployee(listEmployees, eligibleToPromotion);

        }

        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public static void PromoteEmployee(List<Employee> listEmplotyees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (Employee emp in listEmplotyees)
            {
                if (IsEmployeeEligible(emp))
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }
    }
}
