using System;

namespace GOP_01
{
    class Classes
    {
        static void Main()
        {
            var p = new Point(3, 5);
            Console.WriteLine(p.ToString());

            var n = new Shape(3, 5, 2, 4);
            Console.WriteLine(n.ToString());
            Console.WriteLine(n.GetArea());
            Console.WriteLine(n.GetCircumference());

            var p2 = new Point(-3, 6);
            var n2 = new Shape(p2, 4, 3);
            Console.WriteLine(n2.ToString());
            Console.WriteLine(n2.GetArea());
            Console.WriteLine(n2.GetCircumference());

            var p3 = new Point(p);
            var n3 = new Shape(p3, 2, 4);

            Console.WriteLine(n.Equals(n3)
                ? $"Shape {nameof(n)} is equal to shape {nameof(n3)}"
                : $"Shape {nameof(n)} is not identical to shape {nameof(n3)}");
        }
    }

    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }

        public override string ToString()
        {
            return $"Point coordinate (x, y) = ({X}, {Y})";
        }

        public override bool Equals(object obj)
        {
            var point = obj as Point;

            if (point == null)
            {
                return false;
            }

            return X.Equals(point.X) && Y.Equals(point.Y);
        }

        protected bool Equals(Point other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }
    }

    public class Shape : Point
    {
        public double Length { get; private set; }
        public double Hight { get; private set; }

        public Shape(double x, double y, double lenght, double hight) : base(x, y)
        {
            Length = lenght;
            Hight = hight;
        }

        public Shape(Point p, double length, double hight) : base(p)
        {
            Length = length;
            Hight = hight;
        }

        public double GetArea()
        {
            return Length * Hight;
        }

        public double GetCircumference()
        {
            return 2 * Length + 2 * Hight;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Shape lenght = {Length} and Hight = {Hight}";
        }

        public override bool Equals(object obj)
        {
            var shape = obj as Shape;

            if (shape == null)
            {
                return false;
            }

            return base.Equals(obj) && Hight.Equals(shape.Hight) && Length.Equals(shape.Length);
        }

        protected bool Equals(Shape other)
        {
            return base.Equals(other) && Length.Equals(other.Length) && Hight.Equals(other.Hight);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ Length.GetHashCode();
                hashCode = (hashCode * 397) ^ Hight.GetHashCode();
                return hashCode;
            }
        }
    }
}
