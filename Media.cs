using System;
using System.Numerics;

namespace BeeCrowd{

public class Media{
    
    public void PR1005(){

        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        num1 *= 3.5;
        num2 *= 7.5;

        double total = (num1 + num2) / 11;

        Console.WriteLine ($"MEDIA = {total:F5}");
    }
}
}