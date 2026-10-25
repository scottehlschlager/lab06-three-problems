



Random rng = new Random(4000);

System.Console.WriteLine("== CSCI 1250 Lab 06 ==");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All Three");
System.Console.WriteLine("5. Quit");

System.Console.WriteLine("Choose 1 through 5: ");

int choice = Convert.ToInt32(Console.ReadLine());

//System.Console.WriteLine(choice);

if (choice == 1 || choice == 4)
{
    //Exercise 1

    System.Console.WriteLine("=== Exercise 1: The Grade Checker");
    System.Console.Write("Score: ");
    int score = Convert.ToInt32(Console.ReadLine());

    while (score < 0 || score > 100)
    {
        System.Console.WriteLine("A score must be between 0 and 100.");
        System.Console.Write("Score: ");

        score = 0;

        score = Convert.ToInt32(Console.ReadLine());
    }

    if (score >= 90)
    {
        System.Console.WriteLine($"{score} earns an A.");
    }
    else if(score >= 80)
    {
        System.Console.WriteLine($"{score} earns a B.");
    }
        else if(score >= 70)
    {
        System.Console.WriteLine($"{score} earns a C.");
    }
        else if(score >= 60)
    {
        System.Console.WriteLine($"{score} earns a D.");
    }
    else
    {
        System.Console.WriteLine($"{score} earns an F.");
    }
}

if (choice == 2 || choice == 4)
{
    //Exercise 2

    int roll = 0;
    char rollChoice;
    int timesWon = 0;

    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

    do
    {
        rollChoice = 'y';

        if (rollChoice != 'n')
        {
            int dice01 = rng.Next(1, 7);
            int dice02 = rng.Next(1, 7);
            int diceTotal = dice01 + dice02;
            string diceMessage = "";

            if (dice01 == 1 && dice02 == 1)
            {
                diceMessage = "Snake eyes.";
            }
            else if (dice01 == dice02 && dice01 != 1 && dice02 != 1)
            {
                diceMessage = "Doubles!";
            }
            else if (dice01 + dice02 == 7 || dice01 + dice02 == 11)
            {
                diceMessage = "A winner.";
                timesWon++;
            }
            
            

            System.Console.WriteLine($"Roll {roll + 1}: {dice01} and {dice02}, total {diceTotal}. {diceMessage}");
            Console.Write("Roll again? (y/n) ");
            rollChoice = Convert.ToChar(Console.ReadLine());
            
            roll++;

            //rollChoice = 'n';
        }

    }while(rollChoice != 'n');

System.Console.WriteLine($"You rolled {roll} times and won {timesWon}.");

}

if (choice == 3 || choice == 4)
{
    //Exercise 3
    int[] scores = new int[5];

    for (int i = 0; i < scores.Length; i++)
    {
        Console.Write($"Score {i + 1}: ");
        scores[i] = Convert.ToInt32(Console.ReadLine());
    }

    int scoreTotal = 0;
    int highestScore = 0;
    int passingScore = 0;

    foreach (int score in scores)
    {
        scoreTotal = scoreTotal + score;

        highestScore = Math.Max(highestScore, score);

        if (score >= 60)
        {
            passingScore++;
        }
    }

    double scoreAverage = scoreTotal / Convert.ToDouble(scores.Length);

    System.Console.WriteLine($"Scores entered: {scores.Length}");
    System.Console.WriteLine($"Total: {scoreTotal}");
    System.Console.WriteLine($"Average: {scoreAverage}");
    System.Console.WriteLine($"Highest: {highestScore}");
    System.Console.WriteLine($"Passing: {passingScore} of {scores.Length}");


}