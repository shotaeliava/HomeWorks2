using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork6
{
    internal class Program
    {


        static void Main(string[] args)
        {

            /* task1
             console.WriteLine("Enter array length:");
             var size = Convert.ToInt32(Console.ReadLine());
             int[] arr1 = new int[size];
             int[] odd = new int[10];
             int[] even = new int[10];

             Console.WriteLine("insert elements:");

             for (int i = 0; i < arr1.Length; i++)
             {

                 var x = Convert.ToInt32(Console.ReadLine());
                 arr1[i] = x;
                 if (x%2==0)
                 {
                     even[i] = x;

                 }
                 if (x%2!=0)
                 {
                     odd [i] = x;    
                 }
             }
             Console.Write("array even");
             foreach (var item in even)
             {

                 Console.Write(item);
             }
             Console.Write("array odd");
             foreach (var item in odd)
             {

                 Console.Write(item);
             }*/


            /* task2
            Console.WriteLine("arry size");
            var size =Convert.ToInt32( Console.ReadLine());
            int[] cikli = new int[size];
            Console.WriteLine("Enter numbs");
            for (int i = cikli.Length - 1; i >= 0; i--)
            {
                var z = Convert.ToInt32(Console.ReadLine());
                cikli[i] = z;
                

            }
            var dublicates = cikli.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
              .ToList();
            Console.WriteLine(String.Join("/n",dublicates));
            */

            //task3
            Console.WriteLine("To viwe top players enter numb:");
            var x=Convert.ToInt32(Console.ReadLine());
            var Players = new List<int>();
            for (int i = 0; i < x; i++)
            {
                Players.Add(i);

            }
            Players.Reverse();
            foreach (var item in Players.Take(x))
            {
                Console.WriteLine("top players are:");
                Console.WriteLine(item);
            }
            
            




















        }
    }
}
