// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;


    Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");

    Console.WriteLine("What is your name?");

    string name = Console.ReadLine();

    Console.WriteLine("Welcome " + name + " Do you want to do the COIN FLIP CHALLENGE? Yes/No");
    string answer = Console.ReadLine();

    Random rand = new Random();
    int score = 0;


if (answer.Equals("No", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("You are a coward, " + name);
}
else if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Heads or Tails?");
        string choice = Console.ReadLine();
        int num = rand.Next(2);
        /* heads == 0 tails == 1 */
        if (num == 0 && choice.Equals("heads", StringComparison.OrdinalIgnoreCase)) {
            Console.WriteLine("Correct!");
            score += 1;
        } else if (num == 0 && choice.Equals("tails", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Wrong!");
            
        }  else if (num == 1 && choice.Equals("heads", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Wrong!");
            
        } else if (num == 1 && choice.Equals("tails", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Correct!");
            score += 1;
        }
        
    }
    Console.WriteLine("Thanks for playing " + name + ". Your total score was " + score);
}



