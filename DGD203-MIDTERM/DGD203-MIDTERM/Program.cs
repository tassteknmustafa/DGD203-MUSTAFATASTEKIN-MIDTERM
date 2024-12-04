//I used gpt.
using System;

class AdventureGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        Console.Write("What is your name, brave adventurer? ");
        string playerName = Console.ReadLine();

        Console.WriteLine($"\nGreetings, {playerName}! Your choices will shape your journey. Let's begin!");

        int score = 0;

        // Question 1
        Console.WriteLine("\n1. Would you rather explore:");
        Console.WriteLine("   a) A dense, enchanted forest");
        Console.WriteLine("   b) An ancient, cursed castle");
        Console.Write("Your choice (a/b): ");
        string choice1 = Console.ReadLine();
        if (choice1.ToLower() == "a") score += 1;
        else if (choice1.ToLower() == "b") score += 2;

        // Question 2
        Console.WriteLine("\n2. A mystical creature appears! Would you:");
        Console.WriteLine("   a) Try to befriend it");
        Console.WriteLine("   b) Prepare to defend yourself");
        Console.Write("Your choice (a/b): ");
        string choice2 = Console.ReadLine();
        if (choice2.ToLower() == "a") score += 1;
        else if (choice2.ToLower() == "b") score += 2;

        // Question 3
        Console.WriteLine("\n3. You find a treasure chest. Do you:");
        Console.WriteLine("   a) Open it immediately");
        Console.WriteLine("   b) Examine it carefully first");
        Console.Write("Your choice (a/b): ");
        string choice3 = Console.ReadLine();
        if (choice3.ToLower() == "a") score += 1;
        else if (choice3.ToLower() == "b") score += 2;

        // Question 4
        Console.WriteLine("\n4. You hear a strange noise. Do you:");
        Console.WriteLine("   a) Investigate the source");
        Console.WriteLine("   b) Stay where you are and wait");
        Console.Write("Your choice (a/b): ");
        string choice4 = Console.ReadLine();
        if (choice4.ToLower() == "a") score += 1;
        else if (choice4.ToLower() == "b") score += 2;

        // Final remarks
        Console.WriteLine($"\nThank you for your choices, {playerName}!");

        if (score <= 4)
        {
            Console.WriteLine("You are a daring and impulsive adventurer! The thrill of the unknown excites you.");
        }
        else if (score <= 6)
        {
            Console.WriteLine("You balance curiosity with caution. A thoughtful adventurer, you tread carefully!");
        }
        else
        {
            Console.WriteLine("You are methodical and strategic, planning every move. No challenge is too great for your sharp mind!");
        }

        Console.WriteLine("\nYour journey comes to an end for now. Farewell, brave adventurer!");
    }
}
