using System;


namespace Week4_Challenge
{
    class Program
    {

        
        struct Point
        {
            //FIRST DEFINE THE STRUCT
            public int X;
            public int Y;
            
            //CONSTUCTOR
             public Point(int x, int y)
            {
                X = x;
                Y =y;
            }

        }

        GetRandomPoint();
        {
            Random random = new Random();
            //
            Point point = new Point();
            //ASSIGN RANGES TO X AND Y
            minX = -100;
            maxX = 100;
            minY = -100;
            maxY = 100;
            
            point.x = random.Next(minX, maxX);
            point.y = random.Next(minY, maxY);
            //RETURN RANDOM INT TO CALLER
            return point;
        }
           
           //static means you will return a value
        static void Main(string[] args)
        {

            GetRandomPoint();
            //CALL FUNCTION
            Point point = GetRandomPoint();
            //PRINT OUT RANDOM POINT
            Console.WriteLine($"Random Point: {point.X}, {point.Y}");


    



        }     
    }
}