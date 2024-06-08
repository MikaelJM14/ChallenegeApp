using ChallenegeApp;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowniekow");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Poday Kolejna ocene pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");