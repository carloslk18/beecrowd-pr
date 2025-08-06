using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
namespace BeeCrowd.PrCsharp{

class Esfera{


    const double pi = 3.14159;
    public void PR1011(){

        int radius = Convert.ToInt32(Console.ReadLine());

        var vol = calc(radius);

        Console.WriteLine($"VOLUME = {vol:F3}");

    }

    public static double calc(int radius){
        double calc1 = (4/3.0) * pi * Math.Pow(radius,3);
        
        return calc1;
    }
     public static double calc(int radius){
        double calc1 = (4/3.0) * pi * Math.Pow(radius,3);
        
        return calc1;
    }
     public static double calc(int radius){
        double calc1 = (4/3.0) * pi * Math.Pow(radius,3);
        
        return calc1;
    }
}
}
