using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool loop = true;
        while(loop)
        {
            int layer = int.Parse(Console.ReadLine());

            if(layer >= 0)
            {
                for(int i = 0;i <= layer;i++)
                {
                    for(int j = 0;j <= i;j++)
                    {
                        int a = Factorial(i) / (Factorial(j) * Factorial(i-j));

                        Console.Write("{0} ",a);
                    }
                    Console.WriteLine();
                }
                loop = false;
            }
            else
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
            }     
        }
    }
    static int Factorial(int n)
    {
        int sum = 1;
        int m = n;
        for(int i = 0;i < n;i++)
        {
            sum *= m;
            m--;
        }
        return sum;
    }
}