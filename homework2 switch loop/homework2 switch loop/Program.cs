class RockPaperScissors
{
    static void Main()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors");
        Console.WriteLine("");
        Random random = new Random();
        int playerscore = 0;
        int enemyscore = 0;

        while (playerscore < 3 && enemyscore < 3)
        {
            Console.WriteLine("Please choose:");
            Console.WriteLine(" 'rock' / 'paper' / 'scissors' ");
            string choice = Console.ReadLine().ToLower();

            int enemychoice = random.Next(0, 3);
            if (enemychoice == 0)
            {
                Console.Write("Enemy picked Rock");
                switch (choice)
                {
                    case "rock":
                        Console.WriteLine("\nTie!");
                        break;
                    case "paper":
                        Console.WriteLine("\nPlayer wins this round!");
                        playerscore++;
                        Console.WriteLine($"Player: " + playerscore);
                        Console.WriteLine($"Computer: " + enemyscore);
                        break;
                    case "scissors":
                        Console.WriteLine("\nComputer Wins this round!");
                        enemyscore++;
                        Console.WriteLine($"Player: " + playerscore);
                        Console.WriteLine($"Computer: " + enemyscore);
                        break;
                    default:
                        Console.WriteLine("A Error occurred, please make sure to pick one of the named options");
                        break;
                }
            }

            else if (enemychoice == 1)
            {
                Console.WriteLine("Enemy picked Paper");
                switch (choice)
                {
                    case "paper":
                        Console.WriteLine("\nTie!");
                        break;
                    case "scissors":
                        Console.WriteLine("\nPlayer Wins this round!");
                        playerscore++;
                        Console.WriteLine($"Player: " + playerscore);
                        Console.WriteLine($"Computer: " + enemyscore);
                        break;
                    case "rock":
                        Console.WriteLine("\nComputer Wins this round!");
                        enemyscore++;
                        Console.WriteLine($"Player: " + playerscore);
                        Console.WriteLine($"Computer: " + enemyscore);
                        break;
                    default:
                        Console.WriteLine("A Error occurred, please make sure to pick one of the named options");
                        break;
                }
            }

            else
            {
                Console.WriteLine("Enemy picked Scissors");
                switch (choice)
                {
                    case "scissors":
                        Console.WriteLine("\nTie!");
                        break;
                    case "rock":
                        Console.WriteLine("\nPlayer Wins this round!");
                        playerscore++;
                        Console.WriteLine($"Player: " + playerscore);
                        Console.WriteLine($"Computer: " + enemyscore);
                        break;
                    case "paper":
                        Console.WriteLine("\nComputer Wins this round!");
                        enemyscore++;
                        Console.WriteLine($"Player: " + playerscore);
                        Console.WriteLine($"Computer: " + enemyscore);
                        break;
                    default:
                        Console.WriteLine("A Error occurred, please make sure to pick one of the named options");
                        break;
                }
            }
            if (playerscore != 3 && enemyscore != 3)
            {

                Console.WriteLine("\n-click to continue-");
                Console.ReadLine();
                Console.Clear();
            }

        }
        if (playerscore == 3)
        {
            Console.Clear();
            Console.WriteLine($"\nPlayer Wins!  {playerscore} {"/"} {enemyscore}");

        }
        else
        {
            Console.Clear();
            Console.WriteLine($"\nComputer Wins!  {playerscore} {"/"} {enemyscore}");
        }
        Environment.Exit(0);

    }

}