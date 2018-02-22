static void Main(string[] args)
{
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
}