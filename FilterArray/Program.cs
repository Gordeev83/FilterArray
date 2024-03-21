namespace FilterArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования метода
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            int[] filteredArray = FilterArray(originalArray, filterArray);

            Console.WriteLine("Результат работы метода:");
            foreach (int num in filteredArray)
            {
                Console.Write(num + " ");
            }
        }

        static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            return originalArray.Except(filterArray).ToArray();
        }
    }
}
