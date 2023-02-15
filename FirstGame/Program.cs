namespace FirstGame;

class Program
{
    private static Game _game = new Game();

    static void Main()
    {
        
        while (_game.GetWinner() == Winner.None)
        {
            PrintGame();
            char name = char.Parse(Console.ReadLine());
            _game.Turn(name);
            Console.WriteLine(_game.counter);
        }
        PrintGame();
        Winner winner = _game.GetWinner();
        if (winner == Winner.None)
        {
            Console.WriteLine("DRAW");
        }
        else if (winner == Winner.Win)
        {
            Console.WriteLine("YOU WON");
        }
        else
        {
            Console.WriteLine("YOU LOSE");
        }
        Console.ReadKey(true);
    }

    static void PrintGame()
    {
        Console.WriteLine("Игра виселица");
        Console.WriteLine("GUESS THE WORD");
        Console.WriteLine(_game.result);
    }
}

