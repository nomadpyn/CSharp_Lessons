
int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
}

var ThreeNotFive = from i in arr where (i % 5 != 0 && i % 3 == 0) select i;

foreach(int i in ThreeNotFive)
{
    Console.Write(i +"\t");
}