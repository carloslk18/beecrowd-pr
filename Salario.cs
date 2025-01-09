using System;
namespace BeeCrowd{

class Salario{

    public void PR1008(){
        var id = double.Parse(Console.ReadLine());
        var timeSheet = double.Parse(Console.ReadLine());
        var timeValue = double.Parse(Console.ReadLine());

        double salary = timeSheet * timeValue;

        Console.WriteLine($"NUMBER = {id}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");

    }
}
}