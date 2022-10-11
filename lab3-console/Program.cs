class Program
{
    static void Main(String[] args)
    {
        task1();
    }
    static void task1()
    {
        while (true)
        {
            Console.WriteLine("Выберите одной из подзаданий: 1,2,3,4,5,6,7,8");
            Console.WriteLine("Выберите 0 - выход из программы");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Меню успешно создано");
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                default:
                    Console.WriteLine("Выбрано неверное значение. Осуществите выбор повторно.");
                    break;
            }
        }
        Console.ReadKey();
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
    static void task3()
    {
        Console.WriteLine("Введите A:");
        int A = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите B:");
        int B = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Цифры расположены в порядке возрастания:");
        for (int i = A; i <= B; i++)
        {
            Console.WriteLine(i);
        }
        int N = Math.Abs(B - A);
        Console.WriteLine("Количество N введёных чисел:" + N);
        Console.ReadKey();
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
