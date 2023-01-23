

namespace Interfaces
{
    public class Triangle : IFigure
    {
        public double Edge1 { get; set; }
        public double Edge2 { get; set; }
        public double Edge3 { get; set; }
        public double Height1 { get; set; }

        public Triangle()
        {

        }

        public Triangle(double edge1, double edge2, double edge3, double height1)
        {
            this.Edge1 = edge1;
            this.Edge2 = edge2;
            this.Edge3 = edge3;
            this.Height1 = height1;
        }

        public double CalculatePerimeter()
        {
            double perimeter = this.Edge1 + this.Edge2 + Edge3;
            return perimeter;
        }

        public double CalculateArea()
        {
            double area = (Edge1 * Height1) / 2;
            return area;
        }
    }

    public class Rectangle : IFigure
    {
        public double Edge1 { get; set; }
        public double Edge2 { get; set; }

        public double CalculatePerimeter()
        {
            double perimeter = 2*(Edge1 + Edge2);
            return perimeter;
        }

        public double CalculateArea()
        {
            double area = Edge1 * Edge2;
            return area;
        }
    }

    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle() { }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            return perimeter;
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius,2);
            return area;
        }
    }
}
