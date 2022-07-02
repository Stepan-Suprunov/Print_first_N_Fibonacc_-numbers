// Вывести первые N чисел Фибоначчи


Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Ведите положительное число");
}
else if (N == 1)
{
    Console.WriteLine(0);
}
else{
    int[] array = new int[N];

    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < array.Length; i++)
    {
        int mem1 = array[i-2];
     int mem2 = array[i-1];
        array[i] = mem1 + mem2;
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}