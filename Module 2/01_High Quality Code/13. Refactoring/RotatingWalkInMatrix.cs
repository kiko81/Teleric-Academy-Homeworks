namespace RotatingWalkInMatrix
{
    using System;

    public class RotatingWalkInMatrix
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();

            int size;

            while (!int.TryParse(input, out size) || size <= 0 || size > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            Matrix matrix = new Matrix(size);
            Console.WriteLine(matrix);
        }
    }
}
