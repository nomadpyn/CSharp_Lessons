using Humanity;

List<Human> people = new List<Human>
{
    new Human("Петров", "Иван",25),
    new Human("Сидорова", "Маша",21),
    new Human("Будро", "Самсон",35),
    new Human("Иванова", "Елена",45),
    new Human("Петрович", "Тихон",60),
    new Human("Топлева", "Ксения",18)
};


Console.WriteLine("Введите возраст, с которого отсортировать людей");
int sort = int.Parse(Console.ReadLine());

List<Human> selectedPeople = people.Where(h => h.Age >= sort).OrderBy(h => h.Fname).ToList();

foreach (Human i in selectedPeople)
{
    Console.WriteLine(i);
}