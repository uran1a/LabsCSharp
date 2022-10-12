using System;
class Program
{
    static void Main(string[] args)
    {
        task4();
    }
    static void task2()
    {
        int FindEvenNumbers(int[] nums)
        {
            int countEvenNumbers = 0;
            for (int i = 0; i < nums.Length; i++)
                if(nums[i] % 2 == 0) countEvenNumbers++;
            return countEvenNumbers;
        }
        void PrintArray(int[] nums)
        {
            foreach (int num in nums)
                Console.Write(num + " ");
        }
        Console.Write("Введите массив А (в строчку): "); 
        string[] line1 = Console.ReadLine().Split(' ');
        int[] arrayA = Array.ConvertAll(line1, i => Convert.ToInt32(i));

        Console.Write("Введите массив B (в строчку): ");
        string[] line2 = Console.ReadLine().Split(' ');
        int[] arrayB = Array.ConvertAll(line2, i => Convert.ToInt32(i));

        if (FindEvenNumbers(arrayA) > FindEvenNumbers(arrayB)) PrintArray(arrayA);
        else if (FindEvenNumbers(arrayB) == FindEvenNumbers(arrayA)) PrintArray(arrayB);
        else Console.WriteLine("Массиvы равны ;)");
    }
    public static void task4()
    {
        Console.WriteLine("Введите массив в строчку:");
        string[] line = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(line, i => Convert.ToInt32(i));
        array = mergeSort(array);
        foreach (int num in array)
            Console.Write(num + " ");

        static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            if (array.Length <= 1)
                return array;
            int midPoint = array.Length / 2;
            left = new int[midPoint];
            if (array.Length % 2 == 0) right = new int[midPoint];
            else right = new int[midPoint + 1];
            for (int i = 0; i < midPoint; i++) left[i] = array[i];

            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
                right[x++] = array[i];
            left = mergeSort(left);
            right = mergeSort(right);
            result = merge(left, right);
            return result;
        }
        static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}
