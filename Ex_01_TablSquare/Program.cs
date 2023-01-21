// Вывести таблицу квадратов от 1 до N

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
for(int i = 1; i <= N; i++)
    {
        int result = i*i;
        Console.WriteLine(result);
    }