// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



namespace HomeWork5
{
    class Task38
    {
        static void Main(string[] args)
        {
            double[] array = new double[new Random().Next(4, 11)];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine($"Минимальное значение: {GetMin(array)}");
            Console.WriteLine($"Максимальное значение: {GetMax(array)}");
            Console.WriteLine($"Разница между максимальным и минимальным значением в массиве: {GetDifference(array)}");

        }
        static void FillArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(new Random().NextDouble() * (100 - (-100)) + (-100), 2);
                //+ new Random().Next(-99, 100);
            }
        }
        static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static double GetMin(double[] array)
        {
            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            
            return min;
        }
        static double GetMax(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            
            return max;
        }
        static double GetDifference(double[] array)
        {
            double difference = GetMax(array) - GetMin(array);
            return difference;
        }
    }
}