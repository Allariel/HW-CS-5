//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
(double, double) Max_min(double[] array)
{
  double max= array[0];
  double min= array[0];
  foreach (double x in array)
  {
    if (x>max)
    {
        max = x;
    }
    if (x<min)
    {
        min = x;
    }
  }
  return (max, min);
}








void Print_array(double[] array)
{
    Console.Write("[");
    for(int x = 0; x < array.Length;x++)
    {
        if (x == array.Length-1)
        {
            Console.Write(array[x]);
        }
        else
        {
            Console.Write(array[x] + ", " );
        }
    }
    Console.WriteLine("]");
}



double[] Create_array(int n)
{
double[] array = new double[n];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{ 
    array[i] = Math.Round( (1 + rnd.NextDouble() * (1 + 999)) ,3);

 
}

return array;
}




Console.WriteLine("Give Number");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = Create_array(n);
Print_array(array);
double max,min;
(max, min) = Max_min(array);
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine("Max-min: " + Math.Round((max-min),3));
