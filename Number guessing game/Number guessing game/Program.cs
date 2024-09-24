Console.WriteLine("Hello, World!");

Random UnOrthodox = new Random();
bool PlayAGain = true;
int Max = 100;
int Min = 1;
int guess;
int number;
int guesses;
string Response;

while (PlayAGain)
{

    guess = 0;
    guesses = 0;
    Response = "";
    number = UnOrthodox.Next(Min, Max + 1);

    while (guess != number)
    {
        Console.WriteLine(" Guess a number between  " + Min + " - " + Max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Guess: " + guess);

        if (guess > number)
        {
            Console.WriteLine(guess + " is greater than number ");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is less than number ");
        }
        guesses++;
    }
    Console.WriteLine(" Number: " + number);
    Console.WriteLine(" you win ");
    Console.WriteLine(" Guesses : " + guesses);

    Console.WriteLine(" Would You like to play again?? Y/N");
    Response = Console.ReadLine();
    Response = Response.ToUpper();

    if (Response == "Y")
    {
        PlayAGain = true;
    }
    else
    {
        PlayAGain = false;
    }

}

Console.WriteLine(" Thanks for playing");
