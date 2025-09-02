//data_type variable_name = value;
Random r = new Random();
string answer = "";

for (int i = 0; i < int.MaxValue; i++)
{
    Console.WriteLine("Please input lower bound value <<");
    string lowerBound = Console.ReadLine();
    int lower = 0;

    // Below is the code that was moved to a method called ValidateInput
    //while(int.TryParse(lowerBound, out lower) == false)
    //{
    //    Console.WriteLine("Invalid input for lower bound.");
    //    lowerBound = Console.ReadLine();
    //}

    lower = ValidateInput(ref lowerBound);

    Console.WriteLine("Please input upper bound value <<");
    string upperBound = Console.ReadLine();
    int upper = 0;
    upper = ValidateInput(ref upperBound);



    var rando = r.Next(lower, upper + 1); // Generate a random number in the range given by the user. (Second number not included so add one.)

    //Console.WriteLine($"Generated a random number with the value {rando}");

    int guess;
    int count = 0;

    do
    {
        Console.WriteLine($"Please guess a number between {lower} and {upper} <<");
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


    Console.WriteLine("Do you want to try your luck again? yes or no <<");
    answer = Console.ReadLine().ToLower();

    if (answer != "yes")
    {
        i = int.MaxValue;
        break;
    }
}

static int ValidateInput(ref string lowerBound)
{
    int lower;
    while (int.TryParse(lowerBound, out lower) == false)
    {
        Console.WriteLine("Invalid input for lower bound.");
        lowerBound = Console.ReadLine();
    }

    return lower;
}