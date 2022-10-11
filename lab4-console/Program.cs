using System;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };
        int len = numbers.Length;
        Console.WriteLine("Before Merge Sort:");
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine("After Merge Sort");
        SortMethod(numbers, 0, len - 1);
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.Read();
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
    static public void MergeMethod(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;
        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);
        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmp_pos++] = numbers[left++];
            else
                temp[tmp_pos++] = numbers[mid++];
        }
        while (left <= left_end)
            temp[tmp_pos++] = numbers[left++];
        while (mid <= right)
            temp[tmp_pos++] = numbers[mid++];
        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }
    static public void SortMethod(int[] numbers, int left, int right)
    {
        int mid;
        if (right > left)
        {
            mid = (right + left) / 2;
            SortMethod(numbers, left, mid);
            SortMethod(numbers, (mid + 1), right);
            MergeMethod(numbers, left, (mid + 1), right);
        }
    }

}
