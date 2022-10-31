
Book_List A = new Book_List();

int choise;
do
{
    Console.WriteLine("Список книг");
    Console.WriteLine("1- вывести все книги, 2 - добавить книгу, 3 - удалить книгу, 4 - прочитать книгу, 0 - выход");
    choise = int.Parse(Console.ReadLine());
    switch (choise)
    {
        case 1:
            {
                Console.WriteLine(A);
                A.showBooks();
                break;
            }
        case 2:
            {
                Console.WriteLine(A);
                A.addBook();
                break;
            }
        case 3:
            {
                Console.WriteLine(A + "\nКакую удалить?");
                A.removeBook();
                break;
            }
        case 4:
            {
                Console.WriteLine(A+ "\nКакую прочесть?");
                A.readBook();
                break;
            }
        case 0:
            {
                Console.WriteLine("До свидания!");
                break;
            }
        default:
            {
                Console.WriteLine("Ничего не выбрали");
                break;
            }
    }
}
while (choise != 0);
