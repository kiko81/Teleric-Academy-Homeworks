using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    class RefactorLoops
    {
        void Loop(int[] array, int expectedValue)
        {
            //TASK
            //int i = 0;
            //for (i = 0; i < 100; )
            //{
            //    if (i % 10 == 0)
            //    {
            //        Console.WriteLine(array[i]);
            //        if (array[i] == expectedValue)
            //        {
            //            i = 666;
            //        }
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(array[i]);
            //        i++;
            //    }
            //}
            //// More code here
            //if (i == 666)
            //{
            //    Console.WriteLine("Value Found");
            //}

            int index = 0;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    isFound = true;
                    index = i;
                    //break; ?
                }
            }

            if (isFound)
            {
                Console.WriteLine("Expected value found at {0}th index", index);
            }
        }
    }
}

