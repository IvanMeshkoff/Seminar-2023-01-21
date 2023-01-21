// Сумму 

Console.Clear();
Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine());
int result = 0;
for(int i = 1; i <= number; i++)
    {
        result = result+i;
        Console.WriteLine(result);
    }