using Year3ConsoleApp1.Week5;

//var option = EmployeeModels.ReturnGuid();
//Console.WriteLine(option);

//EmployeeModels ob1 = new EmployeeModels();
//var date = ob1.DateTimeEg();
//var date2 = ob1.TimeCountDownEg();
//var stud = ob1.DictionaryEg();
//var stu1d = ob1.ListEg();
//Console.WriteLine(stu1d);

//EmployeeModels.StringBuilderEg();


Console.Write("Your address? ");
var area = Console.ReadLine();
Console.Write("Married or not (true/false)");
var married = Console.ReadLine();
bool marBool = Convert.ToBoolean(married);
Employee.Newlist(area, marBool);