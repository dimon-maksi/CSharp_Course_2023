namespace RandomNumber;

class Program
{
    static void Main(string[] args)
    {
        /*Вгадайте число із 5 спроб за допомогою введення даних з консолі*/
        Random random = new Random();
        int unknownNumber = random.Next(10),
            i = 0,
            userChoice;
        
        Console.WriteLine("Try to guess a number from 0 to 10");

        while (i < 5)
        {
            bool flag = false;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out userChoice);
                if (!flag) Console.WriteLine("Incorrect data, try again:");
            } while (!flag);

            if (userChoice == unknownNumber)
            {
                Console.WriteLine("Right!");
                break;
            }

            i++;
            Console.WriteLine("Try again.");
        }
        if(i == 5) Console.WriteLine("You have used up all your attempts :(");
    }
}