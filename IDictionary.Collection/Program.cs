using static System.Console;

Dictionary<int, string> employees = new();

IDictionary<int, string> iDick = new Dictionary<int, string>();


static string RandomName()
{
    string[] names = { "John", "Paul", "George", "Ringo" };
    Random rnd = new Random();
    int index = rnd.Next(names.Length);
    return names[index];
}

//employees.Add(1,"Fazrin");

for (int i = 0; i < 25; i++)
{
    employees.Add(i,RandomName());
    iDick.Add(i,RandomName());
}

//foreach (var emp in employees)
//{
//    WriteLine("Employee Id : {0}, Employee Name {1}", emp.Key, emp.Value);
//}

foreach (var i in iDick.Reverse())
{
    WriteLine("Employee Id : {0}, Employee Name {1}", i.Key, i.Value);
}

ReadKey();