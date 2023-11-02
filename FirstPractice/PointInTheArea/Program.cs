namespace PointInTheArea;

class Program
{
    static void Main(string[] args)
    {
        /*Перевірити істинність вислову:
         "Точка з координатами (x, у) лежить всередині прямокутника, 
         ліва верхня вершина якого має координати (x1=0, y1=5), 
         права нижня — (x2=5, y2=0), а сторони паралельні координатним осям".*/

        int x,
            y,
            x1 = 0,
            y1 = 0,
            x2 = 5,
            y2 = 5;
        
        Console.WriteLine("Write X:");
        
        bool flag = false;
        do
        {
            flag = int.TryParse(Console.ReadLine(), out x);
            if (!flag) Console.WriteLine("Incorrect data, try again:");
        } while (!flag);
        
        Console.WriteLine("Write Y:");
        
        flag = false;
        do
        {
            flag = int.TryParse(Console.ReadLine(), out y);
            if (!flag) Console.WriteLine("Incorrect data");
        } while (!flag);

        if ((x >= x1 && x <= x2) && (y >= y1 && y <= y2))
        {
            Console.WriteLine("Your point in the area.");
        }
        else
        {
            Console.WriteLine("Out of the area");
        }
    }
}