Console.WriteLine("Welcome to the MathGame!\n");
Console.Write("Please enter your name to get started: ");

string? playerName = Console.ReadLine();
Random rand = new();
decimal playerScore = 0;
string? input;
decimal winningScore = 10;
decimal scoreAdder = 0;
int num1;
int num2;
int expectedAnswer;

decimal additionMultiplier = 1.0;
decimal subtractionMultiplier = 1.1;
decimal multiplyMultiplier = 1.5;
decimal divisionMultiplier = 1.75;

Console.WriteLine();
Console.WriteLine($"Thanks for playing {playerName}\n");
//TODO - need to tell player how many points they need to get to win. 10 sounds reasonable...

do
{
    Console.WriteLine("1. Addition\t\t(1.0x score multiplier)");
    Console.WriteLine("2. Subtraction\t\t(1.1x score multiplier)");
    Console.WriteLine("3. Multiplication\t(1.5x score multiplier)");
    Console.WriteLine("4. Division\t\t(1.75x score multiplier)\n");

    Console.WriteLine("Please select the math game you wish to play (Enter 1 - 4) or type 'exit' to finish playing:");
    input = Console.ReadLine();

    num1 = rand.Next(11);
    num2 = rand.Next(11);

    switch (input)
    {
        case "1":
            Console.WriteLine("You selected 1. Addition");
            additionGame();
            break;
        case "2":
            Console.WriteLine("You selected 2. Subtraction");
            Console.WriteLine("This game is not complete, come back later...");
            Console.ReadLine();
            break;
        case "3":
            Console.WriteLine("You selected 3. Multiplication");
            Console.WriteLine("This game is not complete, come back later...");
            Console.ReadLine();
            break;
        case "4":
            Console.WriteLine("You selected 4. Division");
            Console.WriteLine("This game is not complete, come back later...");
            Console.ReadLine();
            break;
        case "exit":
            Console.WriteLine("Thanks for playing! Press enter to leave...");
            Console.ReadLine();
            //TODO - add in summary of score and how close player was to winning
            break;
        default:
            Console.WriteLine("Invalid Entry. Please try again.");
            break;
    }

    static void updateScore(int value, double multiplier)
    {
        // updates current score by value * multiplier
        playerScore += (value * multiplier)
    }

    static void getValidGame(int num1, int num2)
    {
        // ONLY REQUIRED FOR DIVISION GAME:
        // Takes in two values and determines if the result will be a whole integer. If the result is false this method will re-roll the numbers until a valid equationis reached
        decimal resultCheck = 0;

        do
        {
            resultCheck = (num1 / num2) % 1;
            if (resultCheck != 0)
            {
                Console.WriteLine("Invalid equation, re-rolling numbers...\n");
                num1 = rand.Next(11);
                num2 = rand.Next(11);
            }
        }
        while (resultCheck != 0);
    }

    static void additionGame()
    {
        expectedAnswer = num1 + num2;
        Console.WriteLine($"What is {num1} + {num2}?");
    }

    static void subtractionGame()
    {

    }

    static void multiplyGame()
    {

    }

    static void divisionGame()
    {

    }








}
while (input != "exit");