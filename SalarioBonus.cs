using System;
namespace BeeCrowd{

class SalarioBonus{

    public void PR1009(){

        string nome = Console.ReadLine();
        double fixSalary = double.Parse(Console.ReadLine());
        double commission = double.Parse(Console.ReadLine());

        double salary = commission * 0.15 + fixSalary;

        Console.WriteLine($"TOTAL = R$ {salary:F2}");
    }
}
}