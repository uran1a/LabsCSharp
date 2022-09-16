using System;
class Program
{
    public static void Main(string[] args)
    {
        //task1();
        task2();
    }
    enum Coordinates : int { X1 = 0, Y1, X2, Y2, X3, Y3 }
    static void task1()
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
    static void task2()
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
}