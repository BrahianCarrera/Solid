using System.Globalization;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text.RegularExpressions;

namespace Solid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public List<Shape> shapes = new List<Shape>();
        public void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string option = Shapebox.SelectedIndex.ToString();


            double param1 = double.Parse(textBox1.Text.ToString());
            

            switch (option)
            {
                case "0":

                    Circle circle = new Circle(param1);
                    double areaCircle = circle.Area();
                    resultbox.Text = areaCircle.ToString();
                    shapes.Add(circle);
                    break;

                case "1":

                    double param2 = double.Parse(textBox2.Text.ToString());
                    Rectangle rectangle = new Rectangle(param1, param2);
                    double areaRectangle = rectangle.Area();
                    resultbox.Text = areaRectangle.ToString();
                    shapes.Add(rectangle);
                    break;
                case "2":

                    double param3 = double.Parse(textBox2.Text.ToString());
                    EquilateralTriangle triangle = new EquilateralTriangle(param1, param3);
                    double areaTriangle = triangle.Area();
                    resultbox.Text = areaTriangle.ToString();
                    shapes.Add(triangle);

                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;

            }

        }

        private void comboBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Shapebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Shapebox.SelectedItem != null)
            {
                if (Shapebox.SelectedItem.ToString() == "Circle")
                {
                    textBox1.PlaceholderText = "Enter the radius of the circle";
                    textBox2.PlaceholderText = "Don't type here hehe";
                }

                if (Shapebox.SelectedItem.ToString() == "Rectangle")
                {
                    textBox1.PlaceholderText = "Enter the size of one side of the rectangle";
                    textBox2.PlaceholderText = "Enter the other size the rectangle";
                }

                if (Shapebox.SelectedItem.ToString() == "Triangle")
                {
                    textBox1.PlaceholderText = "Enter the size of one side of the triangle";
                    textBox2.PlaceholderText = "Enter the Angle of the triangle";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AreaCalculator Calculator = new AreaCalculator();
            double result = Calculator.TotalArea(shapes);
            MessageBox.Show("El area total es" + result );
            
        }
    }
}
