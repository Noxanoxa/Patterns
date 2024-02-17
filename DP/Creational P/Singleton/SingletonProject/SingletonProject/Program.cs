using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonProject.ExamplesClasses;

namespace SingletonProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Without considiring if the instance is used or not */

            /*Counter c1 = new Counter();*//* count = 0 */
            /*Counter c2 = new Counter();*/ /* count = 0 */


/*
            c1.AddOne();*//* count = 1 *//*
            c2.AddOne(); *//* count = 1 *//*

            Console.WriteLine("counter 1 :" + c1.count.ToString());
            Console.WriteLine("counter 2 :" + c2.count.ToString());

            c1.AddOne();*//* count = 2 *//*
            Console.WriteLine("counter 1 :" + c1.count.ToString());
            Console.WriteLine("counter 2 :" + c2.count.ToString());
*/


            /* Single Thread*/
            /*            Counter c1 = Counter.GetInstance();
            Counter c2 = Counter.GetInstance();

                        c1.AddOne();*//* count = 1 *//*
                        c2.AddOne(); *//* count = 1 *//*

            Console.WriteLine("counter 1 :" + c1.count.ToString());
            Console.WriteLine("counter 2 :" + c2.count.ToString());

            c1.AddOne();
                        Console.WriteLine("counter 1 :" + c1.count.ToString());*//* counter1 : 3 *//*
                        Console.WriteLine("counter 2 :" + c2.count.ToString());*//* counter2 : 3 */

            /* Multi Threads*/

            Task task1 = Task.Factory.StartNew(() =>
            {
                Counter c1 = Counter.GetInstance();
                c1.AddOne();
                Console.WriteLine("counter 01 :" + c1.count.ToString());
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                Counter c2 = Counter.GetInstance();
                c2.AddOne();
                Console.WriteLine("counter 02 :" + c2.count.ToString());
                Console.WriteLine();
            });

            Task task3 = Task.Factory.StartNew(() =>
            {
                Counter c3 = Counter.GetInstance();
                c3.AddOne();
                Console.WriteLine("counter 03:" + c3.count.ToString());
                Console.WriteLine();
            });
            Console.ReadKey();
        }
    }
}
