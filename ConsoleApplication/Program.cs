using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using ClassLibrary;


namespace ConsolApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

            var shapegen = new List<Shape>();

            Shape3D myshape = null;
            
            float totalArea = 0;


            for (var i = 0; i < 20; i++)
                shapegen.Add(Shape.GenerateShape(new Vector3(3.0f, 3.0f, 4.0f)));

            foreach (var shape in shapegen)
            {
                if (shape is Shape3D)
                {
                    if (myshape == null) myshape = (Shape3D)shape;

                    var k = (Shape3D)shape;

                    if (k.Volume > myshape.Volume) myshape = k;
                }

                Console.WriteLine($"{shape}");
                totalArea += shape.Area;
                
            }

            Console.WriteLine($"Avrege area of all hapes: {totalArea / 20:0.0}");
            Console.WriteLine(
                $"The Shape3D with the largest volume is {myshape}\nwith the volume of: {myshape.Volume:0.0}");
            Console.ReadKey();
        }
    }
}


