using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class LongestString
    {
        static void Main()
        {
            string text ="fgjd*THELONGEST*gjfdg djrgkljdl jdlj dkg jdlfjg kfgjkfdgj ldkj jlfdjg";
            
            Console.WriteLine(text.Split().OrderByDescending(x => x.Length).First());
        }
    }
}
