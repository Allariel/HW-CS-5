//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int Count_even(int[] array)
{
    int sum = 0;
    foreach (int x in array)
    {
        if(x%2==0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}




void Print_array(int[] array)
{
    Console.Write("[");
    foreach (int x in array)
    {
        if (x == array.Last())
        {
            Console.Write(x);
        }
        else
        {
            Console.Write(x + ", " );
        }
    }
    Console.WriteLine("]");
}



int[] Create_array(int n)
{
int[] array = new int[n];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{ 
    array[i] = rnd.Next(100,1000); 
}

return array;
}




Console.WriteLine("Give Number");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Create_array(n);
Print_array(array);
int sum = Count_even(array);
Console.WriteLine("Even: " + sum);