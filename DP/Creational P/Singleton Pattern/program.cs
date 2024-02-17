
using System;

namespace Singleton
{

    public class Counter {
      public int count = 0;
      public void AddOne() { count++;}
    }

  class Program 
  {
    static void main (){
    Counter c1 = new Counter();/* count = 0 */
    c1.AddOne();/* count = 1 */

    Counter c2 = new Counter(); /* count = 0 */
    c2.AddOne(); /* count = 1 */

     /* but this not my goal to count number of users so we have to use singleton pattern */
    }

  }
}
