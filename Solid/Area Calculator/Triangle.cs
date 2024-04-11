public class EquilateralTriangle : Shape {

    private double Side { get; set; }
    private double Height { get; set; }

    public EquilateralTriangle(double side, double height) { 
    
        Side = side;
        Height = height;
    }
    public override double Area()
    {
        return (Side * Height)/2;
    }

}
