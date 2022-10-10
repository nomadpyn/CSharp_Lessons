
int[] Array = new int[10];

Console.WriteLine("Выберете как хотите заполнять массив.");
Console.WriteLine("1 - от 1 до 10\n2 - ввести значения с клавиатуры");
Console.WriteLine("3 - рандомно\n0 - выйти из программы");

int choise = Int32.Parse(Console.ReadLine());   

switch (choise)
{
    case 1:
        {
            for (int i = 0; i < 10;)
                 Array[i] = ++i;
            break;
        }
    case 2:
        {
            for (int i = 0; i < 10; i++)
            {
                Array[i] = Int32.Parse(Console.ReadLine());
            }

            break;
        }
    case 3:
        {
            Random rnd = new Random();
            
            for(int i = 0; i < 10; i++)
            {
                Array[i] = rnd.Next(1,100);
            }
            break;
        }
    case 0:
        {
            Console.WriteLine("До свидания!");
            break;
        }

    default:
        {
            Console.WriteLine("Вы ничего не выбрали\n");
            break;
        }

}

Console.WriteLine("Вывод всего массива на экран");

for (int i = 0; i < 10; i++)
    Console.Write($"{Array[i]} ");

Console.WriteLine("\nВведите индекс массива от 0 до 9 для вывода элемента");
choise = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Индекс {choise} = {Array[choise]} ");