using System;


class Program {
    static void Main() {

        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int tmp = a;
        while (tmp != b) {
            a = tmp;
            if (a < b) {
                tmp = a;
                a = b;
                b = tmp;
            }
            tmp = a - b;
            a = b;
        }
        Console.WriteLine(b);
        
    }
}
