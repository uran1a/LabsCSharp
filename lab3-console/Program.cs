class Program
{
    static void Main(String[] args)
    {
        task4();
    }
    static void task2()
    {
        try
        {
            Console.Write("Введите массив чисел в строчку: ");
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(line, l => Convert.ToInt32(l));
            int count = 0;
            foreach (int num in numbers)
                if (num % 2 != 0) count++;
            Console.WriteLine("Кол-во нечетных чисел:" + count);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Некорректные символы!");
        }
    }
    static void task4()
    {
        try
        {
            Console.Write("Введите массив чисел в строчку: ");
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(line, l => Convert.ToInt32(l));
            if (numbers.Length < 2) throw new Exception("Массив слишком короткий!");
            int max = numbers[0], max_index = 0;
            int min = numbers[0], min_index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max) { max = numbers[i]; max_index = i; }
                if(numbers[i] < min) { min = numbers[i]; min_index = i; }
            }
            Console.WriteLine(max_index > min_index ? "YES" : "NO");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Некорректные символы!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}
