using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp1.Week5
{
    internal class EmployeeModels
    {
        public class EmpModel
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Name { get; set; }
            public string Address { get; set; }
            public bool IsMarried { get; set; }
            public string TaskName { get; set; }
            public bool IsDone { get; set; }
            public bool GoneHone { get; set; }
            public DateTime DueDate { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.Now;
        }
        public static Guid ReturnGuid()
        {
            Guid id = Guid.NewGuid();
            return id;
        }
        public DateTime DateTimeEg()
        {
            //creating date time value
            DateTime christmasEve1 = new(year: 2022, month: 12, day: 24);
            DateTime christmasEve2 = new(year: 2022, month: 12, day: 24, hour: 23, minute: 59, second: 59);
            DateTime christmasEve3 = new DateTime(2022, 12, 24);
            DateTime christmasEve4 = DateTime.Parse("12/24/2022 23:59:59");

            DateTime currDate = DateTime.Now;
            DateTime currDateUTC = DateTime.UtcNow;
            DateTime today = DateTime.Today;
            DateTime tomorrow =today.AddDays(1);

            if (today.Month == 4 && today.Day == 1)
                Console.WriteLine("April Fools!");

            int results = DateTime.Compare(currDate, currDateUTC);
            return currDate;


        }

        public TimeSpan TimeSpanEg()
        {
            TimeSpan timeSpan1 = new TimeSpan(2, 2, 10, 1, 100);
            TimeSpan timeSpan2 = new TimeSpan(1); //milliseconds

            TimeSpan aLittleWhile = TimeSpan.FromSeconds(10);
            TimeSpan quiteAWhile = TimeSpan.FromHours(12);

            return timeSpan1;

        }

        public TimeSpan TimeCountDownEg()
        {
            DateTime christmas = new DateTime(2022, 12, 25);
            DateTime currDate = DateTime.Now;

            TimeSpan tillChristmas = christmas - currDate;

            return tillChristmas;
        }

      
        public static void StringBuilderEg()
        {
            string[] animals = { "dog", "cat", "tiger" };
            StringBuilder animalBuilder = new StringBuilder("");
            animalBuilder.AppendLine("byutiful animals");
            animalBuilder.AppendLine(" ==============");

            foreach (var animal in animals){
                animalBuilder.AppendLine(animal);
            }
            Console.WriteLine(animalBuilder.ToString());
        }

        public List<string> ListEg()
        {
            List<string> employees = new() { "nischal", "bidhan", "ronish", "gauri" };
            Console.WriteLine(employees.Count);
            Console.WriteLine(employees[2]); 
            employees[1] = "dikshyant"; 
            employees.Add("reeya");
            employees.Insert(2, "soman");
            Console.WriteLine(employees);

            return employees;

        }
        public Dictionary<int, string> DictionaryEg()
        {
            Dictionary<int, string> students = new() { { 1, "Nischal" }, { 2, "Bidhyan" }, { 3, "Praatham" } };

            return students;
        }
    }
}
