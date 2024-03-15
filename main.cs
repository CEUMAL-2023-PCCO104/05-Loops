using System;

class Program
{
    public static void Main(string[] args)
    {
        bool isContinue = true;

        while (isContinue)
        {
            Console.WriteLine("Type 'foreach' to execute foreach loop example.");
            Console.WriteLine("Type 'for' to execute for loop example.");
            Console.WriteLine("Type 'do..while' to execute for do..while example.");
            Console.WriteLine("Type 'while' to execute while loop example.");
            Console.WriteLine("Type 'exit' to close the program.");

            Console.WriteLine();
            Console.Write("Command: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input.ToLower())
            {
                case "foreach":
                    Console.WriteLine("Below is a foreach example...");
                    string[] names = { "Ely", "Raymond", "Marcus", "Buddy" };

                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                case "for":
                    Console.WriteLine("Below is a for example...");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Current iteration: {i}");
                    }
                    break;
                case "do..while":
                    Console.WriteLine("Below is a do..while example...");

                    Random random = new Random();
                    int current = 0;

                    do
                    {
                        current = random.Next(1, 11);
                        Console.WriteLine($"Random Number is {current}");
                    } while (current != 7);
                    break;
                case "while":
                    Console.WriteLine("Below is a while example...");

                    Random rnd = new Random();
                    int curr = rnd.Next(1, 11);

                    while (curr >= 3)
                    {
                        Console.WriteLine($"Random Number is {curr}"); ;
                        curr = rnd.Next(1, 11);
                    }
                    break;
                case "exit":
                    Console.WriteLine("Closing the program...");
                    isContinue = false;
                    break;
                default:
                    Console.WriteLine("Invalid Keyword...");
                    break;
            }
            Console.WriteLine();
        }
      }

}