using System;


class Program {
    static void Main() {

        Console.Write("x1 = ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("x2 = ");
        double x2 = double.Parse(Console.ReadLine());
        double x = x1;
        Console.WriteLine("x    sin(x)");
        do {
            double y = Math.Sin(x);
            Console.WriteLine("{0:f2} {1}", x, y);
            x += 0.01;
        } while (x <= x2);
    }
}
