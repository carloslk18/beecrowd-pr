using System;
using System.Runtime.CompilerServices;
namespace BeeCrowd{

public class Area{

    public void PR1012(){
        var val = Console.ReadLine();
        string [] aVal = val.Split(' ');
        double a = double.Parse(aVal[0]);
        double b = double.Parse(aVal[1]);
        double c = double.Parse(aVal[2]);


        var triangulo = cTriangulo(a,c);
        var circulo = cCirculo(c);
        var trapezio = cTrapezio(a,b,c);
        var quadrado = cQuadrado(b);
        var retangulo = cRetantulo(a,b);

        Console.WriteLine($"TRIANGULO: {triangulo:F3}");
        Console.WriteLine($"CIRCULO: {circulo:F3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
        Console.WriteLine($"QUADRADO: {quadrado:F3}");
        Console.WriteLine($"RETANGULO: {retangulo:F3}");

         Console.WriteLine($"TRIANGULO: {triangulo:F3}");
        Console.WriteLine($"CIRCULO: {circulo:F3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:F3}");

    }

    public double cTriangulo(double bas ,double altura){

        double area;
        area = bas * altura / 2;
        return area;
    }

    public double cCirculo(double raio){

        double area;
        area = 3.14159 * Math.Pow(raio,2);
        return area;
    }

    public double cTrapezio(double bas1, double bas2, double altura){

        double area;
        area = (bas1 + bas2) * altura / 2;
        return area;
    }

    public double cQuadrado(double lado){
        double area;
        area = lado * lado;
        return area;
    }

    public double cRetantulo(double bas, double altura){
        double area;
        area = bas * altura;
        return area;
    }
    public double cRetantulo(double bas, double altura){
        double area;
        area = bas * altura;
        return area;public double cRetantulo(double bas, double altura){
}
}

     public double cRetantulo(double bas, double altura){
        double area;
        area = bas * altura;
        return area;public double cRetantulo(double bas, double altura){
}
