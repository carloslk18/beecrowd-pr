using System;
namespace BeeCrowd.PrCsharp{

public class Bigger{

    public void PR1013(){

        string num = Console.ReadLine();

        string [] numP = num.Split(' ');
        int val1 = int.Parse(numP[0]);
        int val2 = int.Parse(numP[1]);
        int val3 = int.Parse(numP[2]);

        if (val1 > val2 && val1 > val3){
            Console.WriteLine($"{val1} eh o maior");
        }
        if (val2 > val1 && val2 > val3){
            Console.WriteLine($"{val2} eh o maior");
        }
        if (val3 > val1 && val3 > val2){
            Console.WriteLine($"{val3} eh o maior");
        }
    }

    public void PR1013v2(){

        string num = Console.ReadLine();

        string [] numP = num.Split(' ');
        int val1 = int.Parse(numP[0]);
        int val2 = int.Parse(numP[1]);
        int val3 = int.Parse(numP[2]);

        var calculo = calculoMaior(val1,val2,val3);
        Console.WriteLine($"{calculo} eh o maior");
    }

    public int calculoMaior(int a, int b, int c){

        int maiorAB = (a + b + Math.Abs(a-b))/2;
        
        int maiorABC = (maiorAB + c + Math.Abs(maiorAB-c))/2;

        return maiorABC;
    }
}
}
