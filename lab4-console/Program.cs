using System;
class Program
{
    static void Main(String[] args)
    {
        task2();
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
}
