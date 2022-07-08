// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



namespace HomeWork5
{
    class Task36
    {
        static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(4, 11)];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine(GetSumEvenPosition(array));

        }
        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-99, 100);
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static int GetSumEvenPosition(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i]; 
            }
            return sum;
        }
    }
}