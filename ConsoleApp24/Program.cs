using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 12, 25, 7, 17 };

            int max = arr[0];
            int max2 = arr[0];
            int min = arr[0];
            int min2 = arr[1];



            foreach (var item in arr)
            {
                if(item<min)
                {
                    min2 = min;
                    min2 = item;
                }
                else if(item<min2&&item!=min)
                {
                    min2 = item;
                }


                if (item > max)
                {
                    max2 = max;
                    max = item;
                }
                else if (item > max2 && item != max)
                {
                    max2 = item;
                }
            }


            Console.WriteLine("En Boyuk Değer:{0}", max);
            Console.WriteLine("En Boyuk 2 ci. Değer:{0}", max2);
            Console.WriteLine("En Kicik Değer:{0}", min);
            Console.WriteLine("En Kicik 2 ci. Değer:{0}", min2);

            int maxcem = max + max2;
            Console.WriteLine("En boyuk 2 ededin cemi :"+maxcem);

            int mincem = min + min2;
            Console.WriteLine("En boyuk 2 ededin cemi :" + mincem);


            Console.WriteLine("Etmek istediyiniz emeliyyati secin");
            Console.WriteLine("- , +  , * , /");
            char c = Convert.ToChar(Console.ReadLine());

            switch (c)
            {
                case '-':
                    Console.WriteLine($"Emeliyyatin neticesi :{ maxcem - mincem}");
                    break;

                case '+':
                    Console.WriteLine($"Emeliyyatin neticesi :{maxcem + mincem}");
                    break;

                case '*':
                    Console.WriteLine($"Emeliyyatin neticesi :{maxcem * mincem}");
                    break;

                case '/':
                    Console.WriteLine($"Emeliyyatin neticesi :{maxcem / mincem}");
                    break;
            }
        }
    }
}
