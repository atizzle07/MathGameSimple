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

Console.WriteLine();
Console.WriteLine($"Thanks for playing {playerName}\n");
//TODO - need to tell player how many points they need to get to win. 10 sounds reasonable...

do
{
    Console.WriteLine("1. Addition\t\t(1.0x score multiplier)");
    Console.WriteLine("2. Subtraction\t\t(1.1x score multiplier)");
    Console.WriteLine("3. Multiplication\t(1.5x score multiplier)");
    Console.WriteLine("4. Division\t\t(1.5x score multiplier)\n");

    Console.WriteLine("Please select the math game you wish to play (Enter 1 - 4) or type 'exit' to finish playing:");
    input = Console.ReadLine();

    num1 = rand.Next(11);
    num2 = rand.Next(11);

    switch (input)
    {
        case "1":
            Console.WriteLine("You selected 1. Addition");
            break;
        case "2":
            Console.WriteLine("You selected 2. Subtraction");
            break;
        case "3":
            Console.WriteLine("You selected 3. Multiplication");
            break;
        case "4":
            Console.WriteLine("You selected 4. Division");
            break;
        case "exit":
            Console.WriteLine("Thanks for playing!");
            //TODO - add in summary of score and how close player was to winning
            break;
        default:
            Console.WriteLine("Invalid Entry. Please try again.");
            break;
    }














}
while (input != "exit");

int addEquation(int x, int y)
{
    //Prints out a randomly generated addition equation 
    Console.Write($"{x} + {y}"); // Make this console.write so the method can be inserted inside another string print
    return x + y;
}