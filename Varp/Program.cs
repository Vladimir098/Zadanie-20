using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 10; // Set N to the desired value
        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            int term1 = 15 + i * i * i * i;
            int term2 = 0;

            for (int j = 1; j <= i; j++)
            {
                term2 += (int)Math.Pow(j, 3);
            }

            sum += term1 + term2;
        }

        int lhs = sum;
        int rhs = 2 * ((N * (N + 1) / 2) * (N * (N + 1) / 2));

        Console.WriteLine(lhs == rhs); // Output true if the condition is satisfied
    }
}