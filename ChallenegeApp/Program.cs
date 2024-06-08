﻿using ChallenegeApp;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowniekow");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new Employee("Adam", "Kamizelich",  "M");

//try
//{ 
//Employee emp = null;
//var name = emp.Surname;
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finally here");
//}


while (true)
{
    Console.WriteLine("Poday Kolejna ocene pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");