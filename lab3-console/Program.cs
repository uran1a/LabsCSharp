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
    static void task1()
    {
        while (true)
        {
            Console.WriteLine("Выберите одной из подзаданий: 1,2,3,4,5,6,7,8");
            Console.WriteLine("Выберите 0 - выход из программы");
            switch (int.Parse(Console.ReadLine()))
            {
                case 0:

                    break;
                case 1:
                    Console.WriteLine("Меню успешно создано");
                    break;
                case 2:

                    break;
                case 3:
                    task3();
                    break;
                case 4:

                    break;
                case 5:
                    Console.WriteLine("Введите предел eps:");
                    double eps = Convert.ToDouble(Console.ReadLine());
                    double sum = 0, s = 999999;
                    for (int i = 1; s > eps; i++)
                    {
                        s = 1 / Math.Sqrt(Factorial(i));
                        Console.WriteLine("{0} член ряда = {1}", i, s);
                        sum += s;
                        Console.WriteLine("промежуточная сумма = {0}", sum);
                    }
                    sum = sum - s;
                    Console.WriteLine("Сумма:" + sum);
                    Console.ReadKey();
                    int Factorial(int m)
                    {
                        if (m == 1) return 1;

                        return m * Factorial(m - 1);
                    }
                    break;
                case 6:

                    break;
                case 7:
                    Console.WriteLine("Введите четырёхзначное число:");
                    int n = Convert.ToInt16(Console.ReadLine());
                    int thousands, hundreds, tens, units, sum1, sum2, sum3;
                    thousands = (n / 1000);
                    hundreds = (n % 1000) / 100;
                    tens = (n % 100) / 10;
                    units = (n % 10);
                    sum1 = thousands + tens;
                    sum2 = thousands + units;
                    sum3 = tens + units;
                    if (sum1 < hundreds)
                    {
                        Console.WriteLine("Первичная сумма цифр: " + sum1);
                    }
                    else if (sum2 < hundreds)
                    {
                        Console.WriteLine("Вторичная сумма цифр: " + sum2);
                    }
                    else if (sum3 < hundreds)
                    {
                        Console.WriteLine("Третичная сумма цифр: " + sum3);
                    }
                    else Console.WriteLine("Все комбинации суммы цифр больше сотен!");
                    Console.ReadKey();
                    break;
                case 8:

                    break;
                default:
                    Console.WriteLine("Выбрано неверное значение. Осуществите выбор повторно.");
                    break;
            }
        }
        Console.ReadKey();
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
}
