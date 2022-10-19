
int i;
getSize(out i);

string[] arr= new string[1];

getArr(ref arr, ref i);
showArr(ref arr);

static void getSize(out int digit)
{
    Console.WriteLine("Введите размер массива");
    digit = Int32.Parse(Console.ReadLine());
}

static void getArr(ref string[] arr, ref int size)
{
    Array.Clear(arr);
    Array.Resize(ref arr, size);
    Console.WriteLine("Заполните массив с клавиатуры словами");
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Console.ReadLine();
}

static void showArr(ref string[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}