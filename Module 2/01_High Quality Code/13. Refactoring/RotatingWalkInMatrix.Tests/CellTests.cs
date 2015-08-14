namespace RotatingWalkInMatrix.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void AddingTwoCellsShouldReturnANewCellWithProperValuesForXAndY()
        {
            var cell = new Cell(3, 3);

            Cell result = cell + cell;

            Assert.AreEqual(result.X, cell.X + cell.X);
            Assert.AreEqual(result.Y, cell.Y + cell.Y);
        }
    }
}
