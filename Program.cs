UC-3
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information

// Compare two lines greater or less than other lines

 UC-2
// See https://aka.ms/new-console-template for more information

// Calulate the lenth of a line
 master
 master
using System;

namespace Line_Comparison
{
    class program
    {
 UC-3
        public static double UserInpur()

 UC-2
        public static double UserInpur()

        public static void UserInpur()
 master
 master
        {
            Console.WriteLine("Enter first co-ordinate of first point");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter second co-ordinate of first point");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n  First point ({x1},{y1})");
 UC-3
            Console.WriteLine("------------------------------------------");


 UC-2
            Console.WriteLine("------------------------------------------");

 master

 master
            Console.WriteLine("\nEnter first co-ordinate of second point");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter second co-ordinate of second point");
            int y2 = Convert.ToInt32(Console.ReadLine());
 UC-3

 UC-2
 master
            Console.WriteLine($"\n  Second point ({x2},{y2})");
            Console.WriteLine("===========================================");

            double lineLength = CalculateLength(x1, y1, x2, y2);
            return lineLength;
 UC-3


            Console.WriteLine($"\n  Second point ({x1},{y2})\n");

            double lineLength = CalculateLength(x1, y1, x2, y2);
            Console.WriteLine("Length of a line: " + lineLength);

 master
 master
        }
        public static double CalculateLength(int x1, int y1, int x2, int y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
            return length;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Line Comparison Program\n");
 UC-3

 UC-2
 master
            Console.WriteLine("For first line\n");
            double firstLineLength = UserInpur();
            Console.WriteLine("\nFor Second line\n");
            double secondLineLength = UserInpur();

            Console.WriteLine($"\nFirst line length: {firstLineLength}\nSecond line length: {secondLineLength}\n");

            bool status = firstLineLength.Equals(secondLineLength);
            if (status == true)
            {
                Console.WriteLine("Two lines are equal");
            }
            else
            {
                Console.WriteLine("Two lines are not equal");
            }
 UC-3



            UserInpur();



 master
 master
        }

    }

 UC-3
}

 UC-2


 master
}
 master
