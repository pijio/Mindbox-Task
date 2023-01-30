using Mindbox.Figures.Interfaces;

namespace Mindbox.Figures.Figures;

public class Triangle : IFigure
{
    public double Aside { get; }
    public double Bside { get; }
    public double Cside { get; }
    public Triangle(double a, double b, double c)
    {
        Aside = a;
        Bside = b;
        Cside = c;
    }
    
    /// <summary>
    /// полупериметр треугольника p=(a+b+c)/2
    /// </summary>
    /// <returns></returns>
    private double HalfPerimeter()
    {
        return (Aside + Bside + Cside) / 2;
    }

    /// <summary>
    /// площадь треугольника
    /// </summary>
    /// <returns></returns>
    public double CalculateArea()
    {
        // извините за это имя переменной, в проде никогда так не напишу :)
        var p = HalfPerimeter();
        return Math.Sqrt(p * (p - Aside) * (p - Bside) * (p - Cside));
    }
    
    /// <summary>
    /// периметр треугольника
    /// </summary>
    /// <returns></returns>
    public double CalculatePerimeter()
    {
        return Aside + Bside + Cside;
    }
    
    /// <summary>
    /// Проверка на то, является ли переданный экземпляр фигуры треугольником
    /// </summary>
    /// <param name="figure"></param>
    /// <returns></returns>
    public bool CheckFigure(IFigure figure)
    {
        return figure is not Triangle;
    }
}