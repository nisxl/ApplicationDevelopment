using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Year3ConsoleApp1.Week5.EmployeeModels;

namespace Year3ConsoleApp1.Week5
{
    internal class Employee
    {
        public static void Newlist(string val, bool val2)
        {
            List<EmpModel> list = new List<EmpModel>
            {
                new EmpModel{Name = "Nischal",IsMarried = true,Address = "Gwarko", TaskName = "Manage Team", DueDate = DateTime.Now.AddDays(1) , IsDone = true},
                new EmpModel{Name = "Gaur",IsMarried = false,Address = "Koteshwor", TaskName = "Front End", DueDate = DateTime.Now.AddDays(2) , IsDone = false},
                new EmpModel{Name = "Pratam",IsMarried = false,Address = "Naxal", TaskName = "Front End", DueDate = DateTime.Now.AddDays(3) , IsDone = true},
                new EmpModel{Name = "Anish", IsMarried = true,Address = "Naxal", TaskName = "Front End", DueDate = DateTime.Now.AddDays(4) , IsDone = true},
                new EmpModel{Name = "Zenish",IsMarried = true,Address = "Chitwan", TaskName = "Backend", DueDate = DateTime.Now.AddDays(5) , IsDone = true},
                new EmpModel{Name = "Sonam",IsMarried = false, Address = "Pokhara",TaskName = "Front End", DueDate = DateTime.Now.AddDays(6) , IsDone = true},
                new EmpModel{Name = "Rea",IsMarried = false, Address = "Pokhara",TaskName = "Backend", DueDate = DateTime.Now.AddDays(7) , IsDone = true},
                new EmpModel{Name = "Sahaj",IsMarried = true, Address = "Naxal",TaskName = "Manage Team", DueDate = DateTime.Now.AddDays(8) , IsDone = true},
                new EmpModel{Name = "Bidhyan",IsMarried = false, Address = "Pokhara",TaskName = "Manage Team", DueDate = DateTime.Now.AddDays(9) , IsDone = true},
                new EmpModel{Name = "Manisha",IsMarried = true, Address = "Gwarko",TaskName = "Accounting" , DueDate = DateTime.Now.AddDays(10) , IsDone = true}
            };

            List<EmpModel> searchList = list.Where(x => x.IsMarried == val2).ToList();
            Console.WriteLine("List of people having Married " + val2);
            foreach (var item in searchList)
            {
                
                Console.WriteLine(item.Name + " from " + item.Address + ",");
            }
            Console.WriteLine(searchList.Select(x => x.Name).FirstOrDefault());

            List<EmpModel> searchList1 = list.Where(x => x.Address.Contains(val)).ToList();

            Console.WriteLine("List of people living in " + val);

            foreach (var item in searchList1)
            {
                Console.WriteLine(item.Name + " from " + item.Address + "," + item.IsDone);
            }

            Console.WriteLine("=================================================");
            Console.WriteLine("This is Sorting");
            List<EmpModel> sortList = list.OrderBy(x => x.CreatedAt).ToList();
            List<EmpModel> sortList1 = list.OrderByDescending(x => x.Name).ToList();

            foreach (var item in sortList1)
            {
                Console.WriteLine(item.Name + " from " + item.Address + "," + item.IsDone);
            }
            List<Guid> selectList = list.Where(x => !x.IsDone).Select(x => x.Id).ToList();

            string listJson = JsonSerializer.Serialize(list);

            string appDataDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appDataDirectory = Path.Combine(appDataDirectoryPath, "MyAppName");
            string todoListFile = Path.Combine(appDataDirectory, "todoList.txt");

            File.WriteAllText(appDataDirectory, listJson);


        }
    }
}
