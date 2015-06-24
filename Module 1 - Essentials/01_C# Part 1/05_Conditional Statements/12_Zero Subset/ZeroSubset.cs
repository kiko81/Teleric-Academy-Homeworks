/*
Problem 12.* Zero Subset

We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.
*/

using System;

class ZeroSubset
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Write b number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Write c number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Write d number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Write e number: ");
            int e = Int32.Parse(Console.ReadLine());
            bool subset = false;

            Console.WriteLine();
            if (a + b +c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a,b,c,d,e);
                subset = true;
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
                subset = true;
            }
            if (a + b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
                subset = true;
            }
            if (a + b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
                subset = true;
            }
            if (a + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
                subset = true;
            }
            if (a + b + c == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
                subset = true;
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
                subset = true;
            }
            if (a + b + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
                subset = true;
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
                subset = true;
            }
            if (a + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
                subset = true;
            }
            if (a + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
                subset = true;
            }
            if (a + b == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, b);
                subset = true;
            }
            if (a + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
                subset = true;
            }
            if (a + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
                subset = true;
            }
            if (a + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, e);
                subset = true;
            }
            if (b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
                subset = true;
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
                subset = true;
            }
            if (b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
                subset = true;
            }
            if (b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
                subset = true;
            }
            if (b + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, c);
                subset = true;
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, d);
                subset = true;
            }
            if (b + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);
                subset = true;
            }
            if (c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
                subset = true;
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
                subset = true;
            }
            if (c + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, e);
                subset = true;
            }
            if (d + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
                subset = true;
            }
            if (a == 0 || b == 0 || c == 0 || d == 0 || e == 0)
            {
                Console.WriteLine("0");
                subset = true;                
            }
            if (!subset)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
