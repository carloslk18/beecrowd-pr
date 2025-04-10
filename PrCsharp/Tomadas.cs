using System;
using System.Numerics;
namespace BeeCrowd.PrCsharp{

class Tomadas{
    public void PR1930(){

        var rules = Console.ReadLine();
        string [] ruleParts = rules.Split(' ');
        int rule1 = Int32.Parse(ruleParts[0]);
        int rule2 = Int32.Parse(ruleParts[1]);   

        var socket = new List<int>{
            rule1, rule2, rule3, rule4
        };

        int sockets = 0;
        foreach (int num in socket){
          sockets += num; 
        }

        int total = sockets-3;

        Console.WriteLine (total);

    }
}    
}
