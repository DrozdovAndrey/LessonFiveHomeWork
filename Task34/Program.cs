// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



namespace HomeWork5
{
    class Task34
    {
        static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(5, 11)];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine(GetEvenNumbers(array));

        }
        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 1000);
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static int GetEvenNumbers(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            return count;
        }
    }
}