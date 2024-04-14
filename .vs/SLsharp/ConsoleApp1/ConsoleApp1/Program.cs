using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double sale = (a - (a * b) / 100);
            Console.WriteLine(sale);


            //int number = Convert.ToInt32(Console.ReadLine());

            //int one = (number / 1000);
            //int three = (number % 100 / 10);
            //int four = (number % 10);
            //int two = (number % 1000 / 100);

            //var a = one * 1000 + two * 100 + three * 10 + four;
            //var b = four * 1000 + one * 100 + two * 10 + three;
            //var c = three * 1000 + four * 100 + one * 10 + two;
            //var d = two * 1000 + three * 100 + four * 10 + one;

            //int first = Math.Max(a, b);
            //int second = Math.Max(b, c);
            //int third = Math.Max(c, d);
            //int four1 = Math.Max(d, a);
            //int maxFS = Math.Max(first, second);
            //int maxFS1 = Math.Max(four1, third);

            //Console.WriteLine(Math.Max(maxFS, maxFS1));



            //int first1 = Math.Max(one, two);
            //int second1 = Math.Max(three, four);
            //int thrid1 = Math.Max(four, two);
            //int four1 = Math.Max(two, three);
            //int maxFS1 = Math.Max(first1, second1);
            //int maxFS2 = Math.Max(thrid1, four1);
            //int maxFS = Math.Max(maxFS1, maxFS2); // maxAll

            //int first2 = Math.Min(one, two);
            //int second2 = Math.Min(three, four);
            //int thrid2 = Math.Min(four, two);
            //int four2 = Math.Min(two, three);
            //int maxFS3 = Math.Min(first2, second2);
            //int maxFS4 = Math.Min(thrid2, four2);
            //int minFS = Math.Min(maxFS3, maxFS4); // minAll

            //int first2Max = Math.Min(first1, second1);
            //int first2Min = Math.Max(first2, second2);
            //int max2FS = Math.Max(first2Max, first2Min);
            //int min2FS = Math.Min(first2Max, first2Min);
            // int second2Max = Math.Max(three, four);
            //int thrid2Max = Math.Max(four, two);
            //int four2Max = Math.Max(two, three);
            //int max2FS1 = Math.Max(first2Max, second2Max);
            //int max2FS2 = Math.Max(thrid2Max, four2Max);
            //int max2FS = Math.Max(first2Max, second2Max); // max2All

            //int first2Min = Math.Min(one, two);
            //int second2Min = Math.Min(three, four);
            //int thrid2Min = Math.Min(four, two);
            //int four2Min = Math.Min(one, three);
            //int min2FS1 = Math.Min(first2Min, second2Min);
            //int min2FS2 = Math.Min(thrid2Min, four2Min);
            //int min2FS = Math.Max(first2Min, second2Min); // min2All


            //Console.WriteLine(maxFS + " " + max2FS + " " + min2FS + " " + minFS);

        }
    }
}
