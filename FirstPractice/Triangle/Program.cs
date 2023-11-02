namespace Triangle;

class Program
{
    static void Main(string[] args)
    {
        /*За допомогою цикла вивести трикутник. Висоту трикутника ввести з консолі*/
        
        int length;
        
        Console.WriteLine("Write the length:");
        
        bool flag = false;
        do
        {
            flag = int.TryParse(Console.ReadLine(), out length);
            if (!flag) Console.WriteLine("Incorrect data, try again:");
        } while (!flag);

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length - i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j <= length - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < length - i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}