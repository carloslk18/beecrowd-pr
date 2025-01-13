using System;

namespace BeeCrowd.PrCsharp{

interface IVoador{
    public void Voar();
}

interface IAquatico{
    public void Nadar();
}

class Duck:IVoador, IAquatico{
    public void Voar(){
        Console.WriteLine("The duck is flying");
    }

    public void Nadar(){
        Console.WriteLine("The duck is swimming");
    }
}
}