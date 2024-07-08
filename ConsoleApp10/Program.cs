namespace ConsoleApp10
{
    using System;

    namespace EmployeeManagement
    {
        #region Enums

        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }

        #endregion


        class Program
        {
            static void Main(string[] args)
            {
                Employee[] EmpArr = new Employee[3];

                EmpArr[0] = new Employee(1, "nedal", SecurityLevel.DBA, 100000.00m, new HireDate { Day = 24, Month = 2, Year = 2002 }, 'M');
                EmpArr[1] = new Employee(2, "osama", SecurityLevel.Guest, 50000.00m, new HireDate { Day = 15, Month = 1, Year = 1969 }, 'F');
                EmpArr[2] = new Employee(3, "salah", SecurityLevel.Secretary, 75000.00m, new HireDate { Day = 20, Month = 12, Year = 1947 }, 'M');

                var sortedEmployees = EmpArr.OrderBy(e => e.HireDate.Year)
                                    .ThenBy(e => e.HireDate.Month)
                                    .ThenBy(e => e.HireDate.Day)
                                    .ToArray();

                foreach (var emp in sortedEmployees)
                {
                    Console.WriteLine(emp);
                }

                int boxingCount = 0;

                Array.Sort(EmpArr, (e1, e2) =>
                {
                    boxingCount++;
                    return e1.HireDate.Year.CompareTo(e2.HireDate.Year) != 0 ? e1.HireDate.Year.CompareTo(e2.HireDate.Year) :
                           e1.HireDate.Month.CompareTo(e2.HireDate.Month) != 0 ? e1.HireDate.Month.CompareTo(e2.HireDate.Month) :
                           e1.HireDate.Day.CompareTo(e2.HireDate.Day);
                });

                Console.WriteLine($"Boxing and Unboxing process has occurred {boxingCount} times.");
            }
        }

      
    }
}
