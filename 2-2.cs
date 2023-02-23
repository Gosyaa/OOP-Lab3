using System;


class Program {
    static void Main() {

        var input = Console.ReadLine().Split();
        int k = int.Parse(input[0]), m = int.Parse(input[1]);
        int ans = 0;
        for (int i = 1; i <= 100; i++) {
            if (i > k && i < m)
                continue;
            ans += i;
        }
        Console.WriteLine(ans);
    }
}
