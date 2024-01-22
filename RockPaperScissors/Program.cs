
const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write($"Choose [r]ock, [p]aper, [s]cissors: ");
string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "rock")
{
    playerMove = Rock; 
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper; 
}
else if(playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);

string computerMoves = "";
switch (computerRandomNumber)
{
    case 1:
        computerMoves = Rock;
        break;
    case 2:
        computerMoves = Paper;
        break;
    case 3:
        computerMoves = Scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMoves}.");

if (playerMove == Rock && computerMoves == Scissors || playerMove == Paper && computerMoves == Rock || playerMove == Scissors && computerMoves == Paper)
{
    Console.WriteLine("You win.");
}
else if (playerMove == Scissors && computerMoves == Rock || playerMove == Rock && computerMoves == Paper || playerMove == Paper && computerMoves == Scissors)
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("This game was a draw.");
}


