using System;
using System.Collections.Generic;
namespace Adding_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0, sayi2 = 0, result = 0 , reverse=0 , rem = 0;
            string line ="";
            short n = short.Parse(Console.ReadLine());
            var numbers = new List<string>();      
            string[] snumbers = new string[n*2];
          
            for ( int i= 0; i<n; i++)
            {
                if (n==1)
                line= line + Convert.ToString(Console.In.ReadLine());
                else if (i==n-1)
                    line = line + Convert.ToString(Console.In.ReadLine());
                else
                    line = line + Convert.ToString(Console.In.ReadLine() + " ");
            }
            snumbers = line.Split(' ');

            for (int i = 0; i<n*2; i++)
            {
                sayi1 = int.Parse(snumbers[i]);
                while(sayi1!=0)
                {
                    rem = sayi1 % 10;
                    reverse = reverse * 10 + rem;
                    sayi1 /= 10;
                }
                sayi1 = reverse;
                reverse = 0; rem = 0;
                i++;
                sayi2 = int.Parse(snumbers[i]);
                while (sayi2 != 0)
                {
                    rem = sayi2 % 10;
                    reverse = reverse * 10 + rem;
                    sayi2 /= 10;
                }
                sayi2 = reverse;
                reverse = 0; rem = 0;
                result = sayi1 + sayi2;
                numbers.Add(Convert.ToString(result));
            }


            for (int i=0;i<n;i++)
            {
                sayi1 = int.Parse(numbers[i]);
                while (sayi1 != 0)
                {
                    rem = sayi1 % 10;
                    reverse = reverse * 10 + rem;
                    sayi1 /= 10;
                }
                result = reverse;
                rem = 0; reverse = 0;
                Console.WriteLine(result);
            }
        }
    }
}
