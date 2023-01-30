using Mindbox.Figures.Interfaces;

namespace Mindbox.Figures.Figures;

public class Circle : IFigure
{
    public double Radius { get; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    /// <summary>
    /// Площадь круга
    /// </summary>
    /// <returns></returns>
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    
    /// <summary>
    /// Периметр круга
    /// </summary>
    /// <returns></returns>
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
    
    /// <summary>
    /// Проверка на то, является ли переданный экземпляр фигуры кругом
    /// </summary>
    /// <param name="figure"></param>
    /// <returns></returns>
    public bool CheckFigure(IFigure figure)
    {
        return !(figure is not Circle);
    }
}