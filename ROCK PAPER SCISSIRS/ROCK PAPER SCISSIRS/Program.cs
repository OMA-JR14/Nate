// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random = new Random();
bool PlayAGain = true;
string Player;
string Computer;
string Answer;

while (PlayAGain == true)
{
    Player = "";
    Computer = "";
    Answer = "";

    while (Player != " ROCK " && Player != " PAPER " && Player != " SCISSORS ")
    {
        Console.WriteLine("Enter ROCK PAPER OR SCISSORS ");
        Player = Console.ReadLine();
        Player = Player.ToUpper();
    }

    switch (random.Next(1, 4))
    {
        case 1:
            Computer = "ROCK";
            break;
        case 2:
            Computer = "PAPER";
            break;
        case 3:
            Computer = "SCISSORS";
            break;
    }
    Console.WriteLine("player: "  + Player );
    Console.WriteLine(" Computer:" + Computer );

    switch (Player)
    {
        case "ROCK":
            if (Computer == "ROCK")
            {
                Console.WriteLine(" DRAW ");
            }
            else if (Computer == "PAPER")
            {
                Console.WriteLine("YOU LOSE ");
            }
            else
            {
                Console.WriteLine(" YOU WIN ");
            }
            break;
        case "PAPER":
            if (Computer == "PAPER")
            {
                Console.WriteLine(" DRAW ");
            }
            else if (Computer == "SCISSORS ")
            {
                Console.WriteLine("YOU LOSE ");
            }
            else
            {
                Console.WriteLine(" YOU WIN ");
            }
            break;
        case "Scissors":
            if (Computer == "ROCK")
            {
                Console.WriteLine(" YOU LOSE  ");
            }
            else if (Computer == "PAPER")
            {
                Console.WriteLine(" YOU WIN");
            }
            else
            {
                Console.WriteLine(" YOU DRAW ");
            }
            break;


    }
    Console.WriteLine(" Would you like to play again Y/N: ");
    Answer = Console.ReadLine();
    Answer = Answer.ToUpper();

    if (Answer == "Y")
    {
        PlayAGain = true;
    }
    else
    {
        PlayAGain = false;
    }


}

Console.WriteLine(" THANKS FOR PLAYING ");
