namespace RotatingWalkInMatrix
{
    using System;

    public class Cell
    {
        public Cell(int row, int col)
        {
            this.X = row;
            this.Y = col;
        }

        public int X { get; set; }
        public int Y { get; set; }


        public static Cell operator +(Cell firstCell, Cell secondCell)
        {
            return new Cell(firstCell.X + secondCell.X, firstCell.Y + secondCell.Y);
        }
    }
}
