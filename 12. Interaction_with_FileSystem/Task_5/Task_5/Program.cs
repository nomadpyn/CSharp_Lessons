
using System.Text.RegularExpressions;

string skorogovor = "Расскажите про покупки\nПро какие про покупки?\nПро покупки, про покупки,\nПро покупочки мои..\n";

Console.WriteLine(skorogovor);

checkBuy(skorogovor);

Console.WriteLine(remakeString(skorogovor));

static void checkBuy(string data)
{
    Regex regex = new Regex(@"\w*окуп\w*");

    var matches = regex.Matches(data);

    Console.WriteLine($"Про покупки упоминается {matches.Count} раз");
    foreach (Match match in matches)
        Console.WriteLine(match.Value);
}

static string remakeString(string data)
{
    Console.WriteLine("На что поменять покупки?");
    string replace = Console.ReadLine();
    Regex regex = new Regex(@"\w*окуп\w*");

    return regex.Replace(data, replace);

}