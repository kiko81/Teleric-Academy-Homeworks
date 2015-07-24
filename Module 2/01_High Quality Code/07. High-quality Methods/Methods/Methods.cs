namespace Methods
{
    using System;

    public class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides of the triangle should be > 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentOutOfRangeException("Sides should be longer than sum of other two sides");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        static string NumberToWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    return "Invalid number!";
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        static void PrintAsNumber(object number, string format)
        {
            string result = string.Empty;

            if (format == "f")
            {
                result = string.Format("{0:f2}", number);
            }
            if (format == "%")
            {
                result = string.Format("{0:p0}", number);
            }
            if (format == "r")
            {
                result = string.Format("{0,8}", number);
            }

            Console.WriteLine(result);
        }


        static double CalcDistance(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            const double precission = 0.00000000001;

            isHorizontal = Math.Abs(y1 - y2) < precission;
            isVertical = Math.Abs(x1 - x2) < precission;

            return distance;
        }

        static void Main()
        {
            var area = CalcTriangleArea(3, 4, 5);
            Console.WriteLine(area);

            var textNumber = NumberToWord(5);
            Console.WriteLine(textNumber);

            var maxValue = FindMax(5, -1, 3, 2, 14, 2, 3);
            Console.WriteLine(maxValue);
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "From Sofia, born at 17.03.1992");

            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
