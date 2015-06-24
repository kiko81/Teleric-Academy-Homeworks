namespace Matrixes
{
    using System;
    using System.Linq;

    class CalculatingMatrecies
    {
        static void Main()
        {
            int row = 3;
            int col = 3;
            var matrix1 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix1[r, c] = r + c + 1;
                }
            }

            //row = 4; // to get exception
            row = 3;
            col = 3;
            var matrix2 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix2[r, c] = r + c + 2;
                }
            }

            Console.WriteLine("1st matrix\n" + matrix1);
            Console.WriteLine("2nd matrix\n" + matrix2);

            Console.WriteLine("Sum\n" + (matrix1 + matrix2));
            Console.WriteLine("Extraction\n" + (matrix1 - matrix2));
            Console.WriteLine("Multiplication\n" + (matrix1 * matrix2));

            if (matrix1) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            Type type = typeof(Matrix<int>);
            
            Console.WriteLine(type.GetCustomAttributes(false)[0]);

        }
    }
}