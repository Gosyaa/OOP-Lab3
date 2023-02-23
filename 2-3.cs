using System;


class Program {
    static void Main() {

        Random rnd = new Random();
        double x_center = rnd.NextDouble() * (double) rnd.Next(-3, 3);
        double y_center = rnd.NextDouble() * (double)rnd.Next(-3, 3);
        int cur = 1;
        while (true) {
            double x, y;
            try {
                var input = Console.ReadLine().Split();
                x = double.Parse(input[0]);
                y = double.Parse(input[1]);
            }
            catch {
                Console.WriteLine("Завершение работы");
                break;
            }
            int key = rnd.Next(0, 1);
            if (key == 0)
                x += rnd.NextDouble();
            else
                x -= rnd.NextDouble();
            key = rnd.Next(0, 2);
            if (key == 0)
                y += rnd.NextDouble();
            else
                y -= rnd.NextDouble();
            int ans = 0;
            if ((x - x_center) * (x - x_center) + (y - y_center) * (y - y_center) <= 1)
                ans = 10;
            else if ((x - x_center) * (x - x_center) + (y - y_center) * (y - y_center) <= 4)
                ans = 5;
            else if ((x - x_center) * (x - x_center) + (y - y_center) * (y - y_center) <= 9 && cur % 2 == 0)
                ans = 1;
            Console.WriteLine(ans);
            cur++;
        }
    }
}
