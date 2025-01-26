using System;
namespace BeeCrowd{
public class CalculoS{

    public void PR1010(){
        var num1 = Console.ReadLine();
        var num2 = Console.ReadLine();


        string [] valP = num1.Split(' ');
        double cod = double.Parse(valP[0]);
        double unit = double.Parse(valP[1]);
        double val = double.Parse(valP[2]);

        string [] valP2 = num2.Split(' ');
        double cod2 = double.Parse(valP2[0]);
        double unit2 = double.Parse(valP2[1]);
        double val2 = double.Parse(valP2[2]);

        double totalProduto1 = unit * val;
        double totalProduto2 = unit2 * val2;
        double total = totalProduto1 + totalProduto2;

        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

    }
}
}