namespace Program
{
    class Program
    {
        static void BurbleSort(int[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < (size - i - 1); j++)

                    if (array[j] > array[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
        }

        static void Main(string[] args)
        {
            int[] arrray = { 99, 52, 36, 84, 55, 39, 7, 1, 9, 120 };

            // Print array before Bubble Sort
            Console.WriteLine("\nArray before Bubble Sort:");
            for (int i = 0; i < arrray.Length; i++)
            {
                Console.Write(arrray[i] + " ");
            }

            BurbleSort(arrray);

            // Print array after Bubble Sort
            Console.WriteLine("\nArray after Bubble Sort:");
            for (int i = 0; i < arrray.Length; i++)
            {
                Console.Write(arrray[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}