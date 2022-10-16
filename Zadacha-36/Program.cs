//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int Sum_noteven(int[] array)
{
    int sum = 0;
    //Считаю нечетные по позиции, не по индексу
    for (int i = 0; i < array.Length; i=i+2)
    {
        sum = sum + array[i];
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
    array[i] = rnd.Next(1,1000); 
}

return array;
}




Console.WriteLine("Give Number");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Create_array(n);
Print_array(array);
int sum = Sum_noteven(array);
Console.WriteLine("NotEven sum: " + sum);