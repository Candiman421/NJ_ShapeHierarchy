namespace Sharp.Business
{
    public abstract class Shape
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }

    public abstract class TwoDimensionalShape : Shape
    {
        public abstract double Area { get; }

        //public override string ToString()
        //{
        //    return GetType().Name;
        //}
    }

    public abstract class ThreeDimensionalShape : Shape
    {
        public abstract double Area { get; }
        public abstract double Volume { get; }
    }

    public class Circle : TwoDimensionalShape
    {
        public double Radius { get; set; }
        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Square : TwoDimensionalShape
    {
        public double Side { get; set; }
        public override double Area => Math.Pow(Side, 2);

        public Square(double side)
        {
            Side = side;
        }
    }

    //public class Triangle : TwoDimensionalShape
    //{
    //    public override double Area => throw new NotImplementedException();
    //}

    public class Sphere : ThreeDimensionalShape
    {
        public double Radius { get; set; }
        public override double Area => 4 * Math.PI * Math.Pow(Radius, 2);

        public override double Volume => (4 / 3) * Math.PI * Math.Pow(Radius, 3);

        public Sphere(double radius)
        {
            Radius = radius;
        }
    }

    public class Cube : ThreeDimensionalShape
    {
        public double Side { get; set; }
        public override double Area => Math.Pow(Side, 2) * 6;
        public override double Volume => Math.Pow(Side, 3);

        public Cube(double side)
        {
            Side = side;
        }
    }

    //public class Tetrahedron : ThreeDimensionalShape
    //{
    //    public override double Area => throw new NotImplementedException();

    //    public override double Volume => throw new NotImplementedException();
    //}
}