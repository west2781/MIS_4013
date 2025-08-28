//data_type variable_name = value;
Random r = new Random();

var rando = r.Next(1, 6); // Generate a random number between 1 and 5. (Second number will not be included in range).

Console.WriteLine($"Generated a random number with the value {rando}");

int guess;
int count = 0;

do
{
    Console.WriteLine("Please guess a number between 1 and 5 <<");
    string usersGuess = Console.ReadLine();
    guess = Convert.ToInt32(usersGuess);
    count++;

    Console.WriteLine($"You guessed:{usersGuess}");
    if (rando != guess)
    {
        if (guess < rando)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect guess, your guess was too low.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Incorrect guess, your guess was too high.");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
} while (guess != rando);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Congratulations you guessed correctly and it only took {count} attempts!");

