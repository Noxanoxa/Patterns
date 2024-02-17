using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject.ExamplesClasses
{
    internal class Counter
    {
            public int count = 0;

        /* private static Counter instance = new Counter();*//* lazy initialization : to solve problem that creating this instance just when i run the program even it don't be used  */
        private static Counter instance = null;
        private static object lockobject = new object();
        private Counter() { }

            public static Counter GetInstance() {
                /*return instance;*/
            if (instance == null) /* this called double check is more saftey than using just lockobject */
            {
                lock (lockobject)
                {
                if (instance == null)
                instance = new Counter();
                }
            }
                return instance;
                
        }        
            public void AddOne() { count++; }
    }
}
