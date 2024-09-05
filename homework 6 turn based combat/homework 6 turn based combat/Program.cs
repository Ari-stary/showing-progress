using System;

class TurnBasedCombat
{
    static void Main()
    {

        Console.WriteLine("Welcome to 'turn based combat");
        Console.WriteLine("");
        Console.WriteLine("Short explaination:");
        Console.WriteLine("This will be just a short simulation of a turn based combat, so no mayor story etc. BUT");
        Console.WriteLine("There are some things im gonna explain before you get into it");
        Console.WriteLine("There will be a 'accuracy stat' aswell as a 'crit' (crit = 2x dmg multiplicator) chance to have some rng in it and to challenge myself");
        Console.WriteLine("");
        Console.WriteLine("With that said, I hope you enjoy this small project");
        Console.WriteLine("Click to continue");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Enemy attacks!");
        Console.WriteLine("");
        Console.ReadLine();
        Console.Clear();

        int playerhp = 100;
        int enemyhp = 100;
        Random random = new Random();
        
       
        while (playerhp != 0 || enemyhp != 0)
        {

            int basicAttackChance = random.Next(1, 6);
            int basicAttackCrit = random.Next(1, 6);
            // int fleeChance = random.Next(1, 101);
            int enemyChoice = random.Next(1, 4);
            int enemyAttackChance = random.Next(1, 6);
            int enemySpecialAttackChance = random.Next(1, 6);
            int enemyAttackCrit = random.Next(1, 6);
            int enemySpecialAttackCrit = random.Next(1, 6);


            int specialAttackChance = random.Next(1, 6);
            int specialAttackCrit = random.Next(1, 6); 

        startswitch:
            Console.WriteLine("Its your turn!");
            Console.WriteLine();
            Console.WriteLine("What do you wanna do? 1 / 2 / 3");
            Console.WriteLine($"Player HP : {playerhp} Enemy HP: {enemyhp}");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Items");
            Console.WriteLine("3. Flee");
            string playerChoice = Console.ReadLine();
            switch(playerChoice)
            {
                case "1":
                    {
                        Console.WriteLine("Choose a option: a / b / c");
                        Console.WriteLine("a. Basic Attack (Dmg 20) (Acc 80) (Crit 20)");
                        Console.WriteLine("b. Special Attack (Dmg 40) (Acc 20) (Crit 80)");
                        Console.WriteLine("c. Go back");
                        string attackChoice = Console.ReadLine();
                        if (attackChoice == "a" && basicAttackChance != 5)
                        {
                            if (basicAttackCrit == 5)
                            {
                                Console.WriteLine("A POWERFUL CRIT!");
                                Console.WriteLine($"Enemy HP:  {enemyhp = enemyhp - 20 * 2}");
                            }
                            else
                            {
                            Console.WriteLine("Player uses 'Basic Attack");
                            Console.WriteLine($"Enemy HP:  {enemyhp = enemyhp - 20}"); 
                            }
                            break;
                        }
                        else if (attackChoice == "b" && specialAttackChance == 5)
                        {
                            if (specialAttackCrit != 5)
                            {
                                Console.WriteLine("A POWERFUL CRIT!");
                                Console.WriteLine($"Enemy HP:  {enemyhp = enemyhp - 40 * 2}");
                            }
                            else
                            {
                            Console.WriteLine("Player uses 'Special Attack");
                            Console.WriteLine($"Enemy HP:  {enemyhp = enemyhp - 40}");
                            }
                            break;
                            

                        }
                        else if (attackChoice == "c")
                        {
                            goto startswitch;
                        }
                        else
                        {
                            Console.WriteLine("Miss!");
                        }
                        break;

                    }
                case "2":
                    {
                        Console.WriteLine("Choose a option:");
                        Console.WriteLine("a. Health potion (20 health)");
                        Console.WriteLine("b. Go back");
                        string itemChoice = Console.ReadLine();
                        if (itemChoice == "a")
                        {
                            Console.WriteLine("You drink the potion");
                            playerhp = playerhp + 20;
                            break;
                        }
                        else
                        {
                            goto startswitch;
                        }
                       
                    }
                case "3":
                    {
                            Console.WriteLine("You cant flee!");
                            goto startswitch;
                    }       
            }
            Console.WriteLine("ENEMY ATTACKS!");
            if (enemyChoice == 1 && enemyAttackChance != 5)
            {
                
                    if (enemyAttackCrit == 5)
                    {
                        Console.WriteLine("A POWERFUL CRIT!");
                        Console.WriteLine($"Player HP:  {playerhp = playerhp - 20 * 2}");
                    }
                    else
                    {
                        Console.WriteLine("Enemy uses 'Basic Attack");
                        Console.WriteLine($"Player HP:  {playerhp = playerhp - 20}");
                    }
                    
                
            }
            else if (enemyChoice == 2 && enemySpecialAttackChance == 5)
            {
                if (enemySpecialAttackCrit != 5)
                {
                    Console.WriteLine("A POWERFUL CRIT!");
                    Console.WriteLine($"Player HP:  {playerhp = playerhp - 40 * 2}");
                }
                else
                {
                    Console.WriteLine("Enemy uses 'Special Attack");
                    Console.WriteLine($"Player HP:  {playerhp = playerhp - 40}");
                }
           
            }
            else
            {
                Console.WriteLine("Enemy missed");
                Console.WriteLine($"Player HP: {playerhp}");
            }

                Console.ReadLine();
                Console.Clear();

            if (playerhp <= 0)
            {
                Console.Clear();
                Console.WriteLine("\nYOU LOST!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (enemyhp <= 0)
            {
                Console.Clear();
                Console.WriteLine("\nYOU WON!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
        }
        
    }
}
