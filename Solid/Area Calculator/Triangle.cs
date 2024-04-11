public class EquilateralTriangle : Shape {

    private double SideA;
    
    private double Height;

    public override double Area()
    {
        return (SideA * Height)/2;
    }

}
