


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
}

if (choice == 3 || choice == 4)
{
    //Exercise 3
}