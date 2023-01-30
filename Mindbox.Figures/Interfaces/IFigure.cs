namespace Mindbox.Figures.Interfaces;

public interface IFigure
{
    double CalculateArea();
    double CalculatePerimeter();
    bool CheckFigure(IFigure figure);
}