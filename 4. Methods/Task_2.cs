
Console.WriteLine("Самое большое слово " + maxWord("привет","красивый","мир"));

Console.WriteLine("Самое маленькое слово " + minWord("привет", "красивый", "мир"));

static string maxWord(params string[] words)
{
    string temp = words[0];

    for (int i = 1; i < words.Length; i++)
    {
        if (words[i].Length > temp.Length)
            temp = words[i];
    }

    return temp;

}

static string minWord(params string[] words)
{
    string temp = words[0];

    for (int i = 1; i < words.Length; i++)
    {
        if (words[i].Length < temp.Length)
            temp = words[i];
    }

    return temp;
}
