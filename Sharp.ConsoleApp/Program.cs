// See https://aka.ms/new-console-template for more information
using Sharp.Business;
using System.Diagnostics;

Console.WriteLine("Hello, World!");


Shape[] shapesArray = new Shape[4];
shapesArray[0] = new Circle(6);
shapesArray[1] = new Square(7);
shapesArray[2] = new Sphere(8);
shapesArray[3] = new Cube(9);


foreach (Shape shape in shapesArray)
{
    if(shape is TwoDimensionalShape)
    {
        Console.WriteLine($"This Shape is a two-dimensional {shape.ToString()}");
        Console.WriteLine($"  Area: {((TwoDimensionalShape)shape).Area}");
    }
    else if(shape is ThreeDimensionalShape)
    {
        Console.WriteLine($"This Shape is a three-dimensional {shape.ToString()}");
        Console.WriteLine($"  Area:   {((ThreeDimensionalShape)shape).Area}");
        Console.WriteLine($"  Volume: {(shape as ThreeDimensionalShape)?.Volume}");
    }
    else
    {
        Debugger.Break();
    }
    //if(typeof(shape).IsSubclassOf(typeof(TwoDimensionalShape)))
    //{

    //}
}