Console.Clear();
int [] arr = new int[12];
int sum1 = 0;
int sum2 = 0;
for (int i=0;i<arr.Length;i++)
{
    arr[i] = new Random().Next(-10,10);
}
for (int j=0;j<12;j++)
{
    Console.WriteLine("arr[" + j +"] = " + arr[j] + " ");
}
for (int b=0;b<arr.Length;b++)
{
    if(arr[b]<0) sum1 = sum1+arr[b];
    else if(arr[b]<0) sum1 = sum1+arr[b];
}
Console.WriteLine("Отрицательная сумма = "+sum1);
Console.WriteLine("Положительная сумма = "+sum2);



// for(int i=0; i < 12; i++)
// {
//     arr[i] = new Random().Next(-10, 10);
// }

// Console.WriteLine("Наш массив имеет вид:");
// for(int j = 0; j < 12; j++) 
// {
//     Console.Write("arr[" + j +"] = " + arr[j] + " ");
// }
