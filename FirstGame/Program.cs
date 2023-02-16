namespace FirstGame;


class Program
{
    private static Game _game = new Game();
    static void Main()
    {
        
        while (_game.GetWinner() == Winner.None)
        {
            PrintGame();
            Console.WriteLine("Введите букву: ");
            string? letString = Console.ReadLine();
            if (letString != "" && letString is not null)
            {
                Char letChar = Char.Parse(letString);
                _game.Turn(letChar);
            }
        }
        PrintGame();
        Console.WriteLine(_game.GetWinner() == Winner.Win ? "Победа" : $"Проиграл, слово было {_game.Word}");
        Console.ReadKey(true);
    }

    static void PrintGame()
    {
        Console.Clear();
        Console.WriteLine($"Слово из {_game.Word.Length} букв, осталось ходов: {_game.Counter}");
        Console.WriteLine(_game.Answer);
        string output = "";
        switch (_game.Counter)
        {
            case 6:
                output = @"
  ____   
 |    
 |
 |
 |
_| ___  ";
                break;
            case 5:
                output = @"
  ____   
 |    |
 |
 |
 |
_| ___  ";
                break;
            case 4:
                output = @"
  ____   
 |    |
 |    O
 |
 |
_| ___  ";
                break;
            case 3:
                output = @"
  ____   
 |    |
 |   _O_
 |
 |
_| ___  ";
                break;
            case 2:
                output = @"
  ____   
 |    |
 |   _O_
 |    |
 |
_| ___  ";
                break;
            case 1:
                output = @"
  ____   
 |    |
 |   _O_
 |    |
 |   /
_| ___  ";
                break;
            case 0:
                output = @"
  ____   
 |    |
 |   _O_
 |    |
 |   / \
_| ___  ";
                break;
        }
        Console.WriteLine(output);
    }
}