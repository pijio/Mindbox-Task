// See https://aka.ms/new-console-template for more information

using Mindbox.Figures.Figures;
using Mindbox.Figures.Interfaces;

// Пункт вычисление площади без знания типа фигуры в compile-time не совсем понял :(
// Решил реализовать интерфейс IFigure с методом CalculateArea и использовать upcast
IFigure triangle = new Triangle(5,4,3);
IFigure circle = new Circle(10);
Console.WriteLine(circle.CheckFigure(triangle));
Console.WriteLine(triangle.CalculateArea());
Console.WriteLine(circle.CalculateArea());