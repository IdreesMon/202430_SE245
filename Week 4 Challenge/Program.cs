using System;


namespace Week4_Challenge
{
    class Program
    {
        struct Point
        {
            //FIRST DEFINE THE STRUCT
            private int x;
            private int y;

            public Point()
            {
                Random rnd = new Random();
                x = rnd.Next(-100, 100);
                y = rnd.Next(-100, 100);
            }

            public int X
            {
                get {
                    if (x == 0)
                    {
                        Console.WriteLine("X not assigned");
                    }

                    return x;
                }
                set {
                    if (value >= -100 && value <= 100)
                    {
                        x = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("X must be between -100 and 100");
                    }
                }
            }

            public int Y
            {
                get { return y; }
                set {
                    if (value >= -100 && value <= 100)
                    {
                        y = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Y must be between -100 and 100");
                    }
                }
            }
        }

        //static means you will return a value
        static void Main(string[] args)
        {
            Point[] points = new Point[10];

            for (int i = 0; i < 10; i++)
            {
                points[i] = new Point();
            }

            foreach (Point p in points)
            {
                Console.WriteLine($"({p.X}, {p.Y})");
            }
        }
    }
}


//setters 
//getters 