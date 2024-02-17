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
            Counter c1 = Counter.GetInstance();
            Counter c2 = Counter.GetInstance();

            c1.AddOne();/* count = 1 */
            c2.AddOne(); /* count = 1 */

            Console.WriteLine("counter 1 :" + c1.count.ToString());
            Console.WriteLine("counter 2 :" + c2.count.ToString());

            c1.AddOne();
            Console.WriteLine("counter 1 :" + c1.count.ToString());/* counter1 : 3 */
            Console.WriteLine("counter 2 :" + c2.count.ToString());/* counter2 : 3 */

            Console.ReadKey();
        }
    }
}
