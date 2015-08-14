namespace RotatingWalkInMatrix.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System.Text;

    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void CreatingMatrixShouldHaveProperSize()
        {
            var size = 5;
            var matrix = new Matrix(size);

            Assert.AreEqual(matrix.Field.GetLength(0),matrix.Field.GetLength(1), size);
        }

        [TestMethod]
        public void MostDownRightCellShouldHaveValueEqualToSize()
        {
            var size = 5;
            var matrix = new Matrix(size);

            Assert.AreEqual(matrix.Field[size - 1, size - 1], size);
        }

        [TestMethod]
        public void MaxElementOfMatrixShouldHaveValueEqualToSquareOfSize()
        {
            var size = 5;
            var matrix = new Matrix(size);
            var max = matrix.Field[0, 0];

            for (int x = 0; x < size; ++x)
            {
                for (int y = 0; y < size; ++y)
                {
                    if (matrix.Field[x, y] > max)
                        max = matrix.Field[x, y];
                }
            }

            Assert.AreEqual(max, size * size);
        }

        [TestMethod]
        public void CheckIfFirstvalueIs1()
        {
            var size = 5;
            var matrix = new Matrix(size);

            Assert.AreEqual(matrix.Field[0, 0], 1);
        }

        [TestMethod]
        public void MatrixToStringShouldProduceExpectedOutputForAValidMatrix()
        {
            var size = 5;
            var matrix = new Matrix(size);
            StringBuilder expected = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    expected.AppendFormat("{0,4}", matrix.Field[i, j]);
                }

                expected.Append(Environment.NewLine);
            }

            Assert.AreEqual(matrix.ToString(), expected.ToString());
        }
    }
}
