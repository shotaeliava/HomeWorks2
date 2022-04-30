using System;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* #region  exercise 1
             Console.WriteLine("Check if divide without remainder is possible ");
             Console.WriteLine("Enter Numb:");
             int YourNumb = Convert.ToInt32(Console.ReadLine());
             int MyNumb = 5;
             int Solution1 = YourNumb % MyNumb;
             int x = 0;
             if (Solution1 == x)
             {
                 Console.WriteLine("Yes!");

             }
             else
             {
                 Console.WriteLine("No!");
             }
             #endregion */
            /* #region exercise2

             Console.WriteLine("funny math");
             Console.WriteLine("enter numb X:");
             var X=Convert.ToDecimal(Console.ReadLine());
             Console.WriteLine("enter numb Y:");
             var Y=Convert.ToDecimal(Console.ReadLine());
             var solution=X+Y;
             var solution1 = X - Y;
             var solution2 = X * Y;
             var solution3 = X / Y;
             if ( X == 0 )

             {
                 Console.WriteLine(Y + X);
                 Console.WriteLine(Y - X);
                 Console.WriteLine(Y * X);
                 Console.WriteLine($"NOT ALLoWed To Divide By Zero { X / Y}");
                            }
             else if ( X<Y)
             {
                 Console.WriteLine(Y + X);
                 Console.WriteLine(Y - X);
                 Console.WriteLine(Y * X);
                 Console.WriteLine(Y / X);
             }
             #endregion */


            /* #region exersice3
            Console.WriteLine("EnTer X:");
            var X =Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("EnTer Y:");
            var Y =Convert.ToDecimal(Console.ReadLine());   
            Console.WriteLine($"X:{ Y}");
            Console.WriteLine($"Y:{X}");
            */

            /*#region exercise 4
            Console.WriteLine("Choose Numb 1-9");
            var Numb=Convert.ToDecimal(Console.ReadLine());
            var I = 1;
            
            while (I<10)
            {
                I++;
                Console.WriteLine(Numb*I);
            }
            #endregion*/
           
            
            #region exercise 5
            Console.WriteLine("Enter Numb:");   
            var Yournumb=Convert.ToByte(Console.ReadLine());
            var MyNumb = 1;
                
            while(MyNumb<=Yournumb)
            {
                MyNumb*=2;
                Console.WriteLine(MyNumb*MyNumb);
                

            }
            #endregion





        }
    }
}
