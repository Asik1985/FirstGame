namespace FirstGame;
public enum Winner
{
    None,
    Win,
    Lose
}

//Тестовая отправка с изменениями
class Game
{
    public string[] allwords { get; set; }
    public string word { get; set; }
    public string result { get; set; }
    public int counter { get; set; }
    public Game()
    {
        allwords = GetAllWords();
        Random rnd = new Random();
        int temp = rnd.Next(allwords.Length);
        word = allwords[temp];
        foreach (var item in word)
        {
            result += "X";
        }
        counter = 6;
    }
    public string[] GetAllWords()
    {
        return File.ReadAllLines("words.txt");
    }
    public void Turn(char letter)
    {
        string tempresult = " ";
        int match = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (letter == word[i])
            {
                tempresult += word[i];
                match++;
            }
            else
            {
                if (result[i] == 'X')
                {
                    tempresult += "X";
                }
                else
                {
                    tempresult += result[i];
                }
            }
        }
        if (match == 0)
        {
            counter--;
        }
        result = tempresult;
    }
    public Winner GetWinner()
    {
        if (word == result)
        {
            return Winner.Win;
        }
        else
        {
            if (counter == 0)
            {
                return Winner.Lose;
            }
            else
            {
                return Winner.None;
            }
        }
    }
}