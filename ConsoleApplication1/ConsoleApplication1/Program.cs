using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp00
{
    class Program
    {
        static void Main(string[] args)
        {

            int lenght = 10, width = 5;
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (j == 0 || j == width - 1) Console.Write("*");
                    else if (i == 0 || i == lenght - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Action<int, int> write = (xp, yp) => { Console.SetCursorPosition(xp, yp); Console.Write("*"); };
 
    int centerX = 20, centerY = 10, radius = 8, x = -radius;
    while (x < radius)
    {
        var y = (int)Math.Floor(Math.Sqrt(radius * radius - x * x));
 
        write(x + centerX, y + centerY);
        y = -y;
        write(x + centerX, y + centerY);
        x++;
    }
    Console.ReadLine(); 
            Console.ReadKey();
}
    
     
       }

    }