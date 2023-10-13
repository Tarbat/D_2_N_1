using System;
using System.Xml.Linq;

class HelloWorld
{
    static void Main()
    {
        int[] num = new int[2] { 0, 1 };
        Console.WriteLine("N - Array Size = ");
        int N = Convert.ToInt32(Console.ReadLine());
        Array.Resize(ref num, N);
        int Len = num.Length;
        Console.WriteLine("Len - Quantity: " + Len);

        for (int i = 0; i != Len; i++)
        {
            num[i] = 0;
            Console.Write(num[i].ToString() + " ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("M - Quantity: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("K - Position: ");
        int K = Convert.ToInt32(Console.ReadLine());
        Array.Resize(ref num, N+K);

        Console.WriteLine("input");
        for (int i = K; i < M+K; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("output");
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i].ToString() + " ");
        }
    }
}
