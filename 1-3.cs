using System;

class Program {
    static void Main() {

        int year = int.Parse(Console.ReadLine());
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
