using System.Security.Cryptography;
using System;
using System.Xml.Linq;

namespace UğraştırıcıFormUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal void AddTextBox(int x, int y, string text)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Name = text;
            this.Controls.Add(textBox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    double radius;
                    if(double.TryParse(textBox1.Text, out radius))
                    {
                        Circle circle = new Circle(radius);
                        MessageBox.Show($"Area: {circle.CalculateArea()}\nPerimeter: {circle.CalculatePerimeter()}");
                    }
                    else
                    {
                        MessageBox.Show("Invalid input, please enter a valid number");
                    }    
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    double sideLength;
                    if (double.TryParse(textBox2.Text, out sideLength))
                    {
                        Square square = new Square(sideLength);
                        MessageBox.Show($"Area: {square.CalculateArea()}\nPerimeter: {square.CalculatePerimeter()}");
                    }
                    else
                    {
                        MessageBox.Show("Invalid input, please enter a valid number");
                    }
                }
                else if(comboBox1.SelectedIndex == 2)
                {
                    double baseLength;
                    double secondLength;
                    double thirdLength;
                    double heightLength;
                    if(double.TryParse(textBox3.Text, out baseLength)&&double.TryParse(textBox4.Text, out secondLength) && double.TryParse(textBox5.Text, out thirdLength) && double.TryParse(textBox6.Text, out heightLength))
                    {
                        Triangle triangle = new Triangle(baseLength, secondLength, thirdLength, heightLength);
                        MessageBox.Show($"Area: {triangle.CalculateArea()}\nPerimeter: {triangle.CalculatePerimeter()}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a shape, press other button and enter values");
            }
            
        }

        internal class Circle : IShape
        {
            
            public double Radius { get; set; }
            public Circle(double radius)
            {
                Radius = radius;
            }
            public double CalculateArea()
            {
                double area = Math.PI * Math.Pow(Radius, 2);
                return area;
            }

            public double CalculatePerimeter()
            {
                double perimeter = 2 * Math.PI * Radius;
                return perimeter;
            }
        }

        internal class Square : IShape
        {
            public double SideLength { get; set; }

            public Square(double sideLength)
            {
                SideLength = sideLength;
            }

            public double CalculateArea()
            {
                double area = Math.Pow(SideLength, 2);
                return area;
            }

            public double CalculatePerimeter()
            {
                double perimeter = 4 * SideLength;
                return perimeter;
            }
        }

        internal class Triangle : IShape
        {
            public double FirstEdge { get; set; }
            public double SecondEdge { get; set; }
            public double ThirdEdge { get; set; }
            public double Height { get; set; }

            public Triangle(double baseLength, double secondLength, double thirdLength, double heightLength)
            {
                FirstEdge = baseLength;
                SecondEdge = secondLength;
                ThirdEdge = thirdLength;
                Height = heightLength;
            }

            public double CalculateArea()
            {
                double area = FirstEdge * Height / 2;
                return area;
            }

            public double CalculatePerimeter()
            {
                double perimeter = FirstEdge + SecondEdge + ThirdEdge;
                return perimeter;
            }
        }
    }
}
