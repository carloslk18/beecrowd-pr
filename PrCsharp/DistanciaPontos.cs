using System;

namespace BeeCrowd.PrCsharp{
public class DistanciaPontos {

    public static void Problem(){

        string val1 = Console.ReadLine();
        string [] val1Parts = val1.Split(' ');
        double x1 = Convert.ToDouble(val1Parts[0]);
        double y1 = Convert.ToDouble(val1Parts[1]);

        string val2 = Console.ReadLine();
        string [] val2Parts = val2.Split(' ');
        double x2 = Convert.ToDouble(val2Parts[0]);
        double y2 = Convert.ToDouble(val2Parts[1]);

        Operation(x1,y1,x2,y2);

        //Console.WriteLine("{0:F3} km/l",cons);
    }

    static void Operation(double x1, double y1, double x2, double y2){
        double pow1 = Math.Pow((x2-x1), 2);
        double pow2 = Math.Pow((y2-y1), 2);
        double distance = Math.Sqrt(pow1 + pow2);

        Console.WriteLine("{0:F4}",distance);

    }
}
}

