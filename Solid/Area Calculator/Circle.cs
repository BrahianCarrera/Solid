public class Circle : Shape {

    private double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area()
    {
        double area = Radius * Radius;
        int intnumber = Convert.ToInt32(area);
        return area;
    }

}