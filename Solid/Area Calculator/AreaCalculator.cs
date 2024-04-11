using System.Reflection.Metadata.Ecma335;

public class AreaCalculator {

    public double TotalArea(Shape[] shapes)
    {
        double area = 0;
        foreach (Shape shape in shapes)
        {
             area += shape.Area();
        }
        return area;
    }

}