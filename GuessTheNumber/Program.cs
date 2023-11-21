class Program
{
    static void Main(string[] args)
    {

        Random GuessTheNumber = new Random();

        int number = GuessTheNumber.Next(0, 101);

        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        { 
        Console.WriteLine("Guess a number");
        int guess = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You guessed " + guess);

        if (guess == number)
        {
            Console.WriteLine("You guessed wright, great job!");
                guessedCorrectly = true;
        }
        else if(guess > number)
        {
            Console.WriteLine("Guess is too high");
                guessedCorrectly = false;
        }
        else
        {
            Console.WriteLine("Guess is too low");
                guessedCorrectly = false;
        }
    }
}
}