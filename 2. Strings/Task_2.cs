
Console.WriteLine("Введите слово");
string? word = Console.ReadLine();

int length = word.Length;

word = word.PadLeft(length*2, '*');
word = word.PadRight(length*3, '*');

Console.WriteLine(word);

word = word.Replace("*", "#");

Console.WriteLine(word);

word = word.Trim('#');

Console.WriteLine(word);

Console.WriteLine("Введите слово из двух букв для поиска в первом слове");
string? two = Console.ReadLine();

if (word.Contains(two))
{
    Console.WriteLine($"слово \"{two}\" есть в слове \"{word}\" в индексе {word.IndexOf(two)} ");
}
else
    Console.WriteLine($"слово \"{two}\" нет в слове \"{word}\"");