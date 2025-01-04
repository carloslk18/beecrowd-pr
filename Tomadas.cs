using System;
using System.Numerics;
namespace BeeCrowd{

class Tomadas{
    public void PR1930(){

        int total = 0;

        var rules = Console.ReadLine();
        string [] ruleParts = rules.Split(' ');
        int rule1 = Int32.Parse(ruleParts[0]);
        int rule2 = Int32.Parse(ruleParts[1]);
        int rule3 = Int32.Parse(ruleParts[2]);
        int rule4 = Int32.Parse(ruleParts[3]);

        var socket = new List<int>{
            rule1, rule2, rule3, rule4
        };

        foreach (int num in socket){
          total += num; 
        }

        Console.WriteLine (total-3);

    }
}    
}