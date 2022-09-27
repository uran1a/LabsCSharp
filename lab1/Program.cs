using System;
using lab1;
public class Program
{
    public static void Main(string[] args)
    {
        task1Subtask1();
       
    }
    enum Coordinates : int { X1 = 0, Y1, X2, Y2, X3, Y3 }
    static void task1Subtask1()
    {
        Console.WriteLine("Введите x,y,z:");
        FindResultVariables(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), out double a, out double b);
        Console.WriteLine($"A: {a}");
        Console.WriteLine($"B: {b}");
        void FindResultVariables(double x, double y, double z, out double a, out double b)
        {
            a = (Math.Abs(5 - 2 * Math.E) / (1 + Math.Pow(x, 2) * (y - Math.Tan(z))));
            b = Math.Abs(y - 4) + (Math.Pow(y - x, 2) / 6) + (Math.Pow(x - y, 2) / 7);
        }
    }
    static void task1Subtask2()
    {
        const int SIZE = 6;
        Console.WriteLine("Введите x1, y1, x2, y2, x3, y3: ");
        string[] line = Console.ReadLine().Split(' ');
        int[] arrVariables = new int[SIZE];
        if (line.Length == SIZE)
            for (int i = 0; i < line.Length; i++)
                arrVariables[i] = Convert.ToInt32(line[i]);
        double a = Math.Sqrt(
            Math.Pow(arrVariables[(int)Coordinates.X1] - arrVariables[(int)Coordinates.X2], 2) 
            +
            Math.Pow(arrVariables[(int)Coordinates.Y1] - arrVariables[(int)Coordinates.Y2], 2));
        double b = Math.Sqrt(
            Math.Pow(arrVariables[(int)Coordinates.X2] - arrVariables[(int)Coordinates.X3], 2)
            +
            Math.Pow(arrVariables[(int)Coordinates.Y2] - arrVariables[(int)Coordinates.Y3], 2));
        double c = Math.Sqrt(
            Math.Pow(arrVariables[(int)Coordinates.X1] - arrVariables[(int)Coordinates.X3], 2)
            +
            Math.Pow(arrVariables[(int)Coordinates.Y1] - arrVariables[(int)Coordinates.Y3], 2));
        double Perimeter = (a + b + c) / 2;
        double Square = Math.Sqrt(Perimeter*(Perimeter-a)*(Perimeter-b)*(Perimeter-c));
        double Radius = (a * b * c) / (4 * Square);
        Console.WriteLine($"Радиус: {Radius}");
    }
    static void task1Subtask3()
    {
        Console.WriteLine("Введите число 1: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число 2: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double sum;
        double proiz;
        if (a != b)
        {
         sum = a + b;
         proiz = a * b;
         Console.WriteLine("Сумма введёных чисел: " + sum);
         Console.WriteLine("Произведение введёных чисел: " + proiz);
        }
        else Console.WriteLine("Введите числа неравные друг другу");
        Console.ReadKey();
    }
    static void task1Subtask4()
    {
        Console.WriteLine("Введите время суток:");
        double vremya = Convert.ToDouble(Console.ReadLine());
        if (vremya >= 0 && vremya <= 24)
        {
            Console.WriteLine("Время суток: " + vremya + ":00");
        }
        else Console.WriteLine("Введите значение из заданного промежутка");
        Console.ReadKey();
    }
    static void task2()
    {
        Person p1 = new Person("Nikita", "Zab", "Ser", 18, 1.5, 30000);
        Console.WriteLine(p1.ToString());
        Director d1 = new Director("Sergey", "Zab", "Pav", 45, 3.5, 130000, 3.0, 2);
        Console.WriteLine(d1.ToString());
        Guard g1 = new Guard("Вася", "Пупкин", "Петрович", 49, 15.0, 25000, "Орел");
        Console.WriteLine(g1.ToString());
        Accountant a1 = new Accountant("Олег", "Петров", "Андреевич", 49, 15.0, 25000, 12.4);
        Console.WriteLine(a1.ToString());
        Company admin = new Company("OOO Company", d1, a1, g1);
        Employee e1 = new("Женя", "Клубника", ":0", 31, 3.0, 45000, "SMM", "Sber");
        Employee e2 = new("Алексей", "Дыня", ":)", 33, 1.0, 15000, "Юридический", "Яндекс");
        List<Employee> listEmployee = new List<Employee>() { e1, e2, };
        admin.AddEmployee(listEmployee);
        admin.DeleteEmployee();
        admin.PrintStructOfCompany();
        Console.Read();
    }
}