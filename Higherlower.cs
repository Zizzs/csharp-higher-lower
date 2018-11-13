using System;
using System.Collections.Generic;


class NumberGame
{

    public int initialNumber = 50;
    public int upperBound = 100;
    public int lowerBound = 0;

    public void UserNumberFinder()
    {
        Console.WriteLine("Is your number higher or lower than " + initialNumber + "? (Higher/Lower/Correct)");
        string direction = Console.ReadLine().ToLower();

        while (direction != "correct")
        {
            int newNumber = initialNumber;
            if (direction == "lower")
            {
                upperBound = initialNumber;
                newNumber -= ((initialNumber - lowerBound) /2 );
                initialNumber = newNumber;
            }
            else{
                lowerBound = initialNumber;
                newNumber += ((upperBound - initialNumber) / 2);
                initialNumber = newNumber;
            }
            Console.WriteLine("Is your number higher or lower than {0}? (Higher/Lower/Correct)", newNumber);
            direction = Console.ReadLine().ToLower();
        }
        if (direction == "correct")
        {
            Console.WriteLine("I guessed your Number!");
        }
    }

    public void ComputerNumberFinder()
    {
        Random rnd = new Random();
        int rndNumber = rnd.Next(1, 101);
        Console.WriteLine("The computer has picked a random number, please enter your guess: ");
        int guess = int.Parse(Console.ReadLine());
        while (guess != rndNumber)
        {
            if (guess < rndNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
            guess = int.Parse(Console.ReadLine());
        }
        if (guess == rndNumber)
        {
            Console.WriteLine("You got it right!");
        }
    }

}

class Program
{
    public static void Main()
    {
        NumberGame myNumber = new NumberGame();
        Console.WriteLine("Would you like to play the higher/lower game?(Y/N)");
        string answer = Console.ReadLine();
        if (answer == "Y" || answer == "y")
        {
            Console.WriteLine("Would you like the computer to guess your number (A), or would you like to guess it's number? (B)");
            string userResponse = Console.ReadLine();
            if(userResponse == "A" || userResponse =="a")
            {
                myNumber.UserNumberFinder();
            }
            else{
                myNumber.ComputerNumberFinder();
            }
        }
        else
        {
            Console.WriteLine("Goodbye, see you soon!");
            System.Environment.Exit(0);
        }

    }
}