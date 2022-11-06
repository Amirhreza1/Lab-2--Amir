using System.Numerics;

namespace ClassLibrary
{
    public abstract class Shape
    {
        public static readonly Random random = new Random();
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            var RandomShape = random.Next(0, 6);

            switch (RandomShape)
            {
                case 0:
                    return new Circle(new Vector2((float)RandomFloat(1, 5), (float)RandomFloat(1, 5)),
                        (float)RandomFloat(1, 5));

                case 1:
                    return new Rectangle(new Vector2((float)RandomFloat(1, 5), (float)RandomFloat(1, 5)),
                        new Vector2((float)RandomFloat(1, 5), (float)RandomFloat(1, 5)));

                case 2:
                    return new Rectangle(new Vector2((float)RandomFloat(1, 5), (float)RandomFloat(1, 5)),
                        (float)RandomFloat(1, 5));

                case 3:
                    return new Cuboid(
                        new Vector3((float)RandomFloat(1, 5), (float)RandomFloat(1, 5), (float)RandomFloat(1, 5)),
                        new Vector3((float)RandomFloat(1, 5), (float)RandomFloat(1, 5), (float)RandomFloat(1, 5)));

                case 4:
                    return new Cuboid(
                        new Vector3((float)RandomFloat(1, 5), (float)RandomFloat(1, 5), (float)RandomFloat(1, 5)),
                        (float)RandomFloat(1, 5));

                case 5:
                    return new Sphere(
                        new Vector3((float)RandomFloat(1, 5), (float)RandomFloat(1, 5), (float)RandomFloat(1, 5)),
                        (float)RandomFloat(1, 5));
            }


            return null;
        }

        public static Shape GenerateShape(Vector3 centerInput)
        {
            var RandomShape = random.Next(0, 6);

            switch (RandomShape)
            {

                case 0:
                    return new Circle(new Vector2(centerInput.X, centerInput.Y), (float)RandomFloat(1, 5));

                case 1:
                    return new Rectangle(new Vector2(centerInput.X, centerInput.Y),
                        new Vector2((float)RandomFloat(1, 5), (float)RandomFloat(1, 5)));

                case 2:
                    return new Rectangle(new Vector2(centerInput.X, centerInput.Y), (float)RandomFloat(1, 5));


                case 3:
                    return new Cuboid(new Vector3(centerInput.X, centerInput.Y, centerInput.Z),
                        new Vector3((float)RandomFloat(1, 5), (float)RandomFloat(1, 5), (float)RandomFloat(1, 5)));


                case 4:
                    return new Cuboid(new Vector3(centerInput.X, centerInput.Y, centerInput.Z), (float)RandomFloat(1, 5));


                case 5:
                    return new Sphere(new Vector3(centerInput.X, centerInput.Y, centerInput.Z), (float)RandomFloat(1, 5));
            }


            return null;
        }

        public static double RandomFloat(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
