
using System;

namespace Singleton
{

    public class Counter {
      public int count = 0;
      public void AddOne() { count++;}
    }

  class Program 
  {
    Counter c = new Counter();

  }
}
