using System;
using System.Reflection.Metadata;

namespace BeeCrowd.PrCsharp{

class Lanche{

    public static void PR1038(){
        string val = Console.ReadLine();
        string[] valParts = val.Split(" ");
        int cod = Int32.Parse(valParts[0]);
        double qnt = Double.Parse(valParts[1]);
        double total = 0;

        switch (cod){
            case 1:
            total = 4 * qnt;
            break;

            case 2:
            total = 4.5 * qnt;
            break;

            case 3:
            total = 5 * qnt;
            break;

            case 4:
            total = 2 * qnt;
            break;

            case 5:
            total = 1.5 * qnt;
            break;

        }

        Console.WriteLine($"Total: R$ {total:F2}");

    }
}
}