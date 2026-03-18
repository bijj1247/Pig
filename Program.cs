using System;
class PigGame
{

    //Problem Sttement:
    // Let's Play PIG!
    //* See how many turns it takes you to get to 20.
    //* Turn ends when you hold or roll a 1.
    //* If you roll a 1, you lose all points for the turn.
    //* If you hold, you save all points for the turn.
    static void Main()
    {
        Random random = new Random();
        int totalScore = 0;
        int turnCount = 0;
        Console.WriteLine("PIG DICE GAME ");
        Console.WriteLine("problem statement: Reaching 20 points");
        while (totalScore < 20)
        {
            turnCount++;
            int turnScore = 0;
            bool isTurnOver = false;
            Console.WriteLine($"\n--- Turn {turnCount} ---");
            while (!isTurnOver)
            {
                Console.WriteLine($"Current Total Score: {totalScore}");
                Console.WriteLine($"Turn Score: {turnScore}");
                Console.Write("Enter 'r' to Roll or 'h' to Hold: ");
                string input = Console.ReadLine().ToLower();
                if (input != "r" && input != "h")
                {
                    Console.WriteLine("Invalid input!Please enter only 'r' or 'h'.");
                    continue;
                }
                if (input == "r")
                {
                    int dice = random.Next(1, 7);
                    Console.WriteLine($"You rolled: {dice}");
                    if (dice == 1)
                    {
                        Console.WriteLine("You rolled a 1,turn over");
                        turnScore = 0;
                        isTurnOver = true;
                    }
                    else
                    {
                        turnScore += dice;
                    }
                }
                else
                {
                    totalScore += turnScore;
                    Console.WriteLine($"You chose to hold. Total Score is now: {totalScore}");
                    isTurnOver = true;
                }
            }
        }
        Console.WriteLine($"Congratulations! You reached 20 points.");
        Console.WriteLine($"Total Turns Taken: {turnCount}");
    }
}