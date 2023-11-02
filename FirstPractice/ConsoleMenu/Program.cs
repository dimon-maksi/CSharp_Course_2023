namespace ConsoleMenu;

class Program
{
    static void Main(string[] args)
    {
        bool status = true;
        string choice;
        while (status)
        {
            Console.WriteLine("Make your choice:");
            Console.WriteLine("[1] - First\t[2] - Second\n[3] - Third\t[4] - Exit");
            
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You choose the first");
                    break;
                case "2":
                    Console.WriteLine("You choose the second one");
                    break;
                case "3":
                    Console.WriteLine("You choose the third)");
                    break;
                case "4":
                    Console.WriteLine("Bye!");
                    status = !status;
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}