using System;

namespace ConsoleApp3
{
    class AreaRectangle
    {
        static void Main()
        {
            //Console.WriteLine("Hello World!");
            Console.Write("Please write the length of a rectangle:");
            decimal lengthSide = decimal.Parse(Console.ReadLine());
            Console.Write("Please write the width of a rectangle:");
            decimal widthside = decimal.Parse(Console.ReadLine());

            decimal area = lengthSide * widthside;

            
            Console.WriteLine("The area of the rectangle is: {0}", area);
               

        }
    }
}
