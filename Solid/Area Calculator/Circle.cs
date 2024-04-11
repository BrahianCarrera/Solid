public class Circle : Shape {

    private double Radius;

    public override double Area()
    {
        return Radius * Radius* Math.PI;
    }

}