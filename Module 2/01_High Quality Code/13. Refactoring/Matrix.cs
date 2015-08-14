namespace RotatingWalkInMatrix
{
    using System;
    using System.Text;

    public class Matrix
    {
        private readonly Cell[] directions;
        private readonly int numberOfDirections;

        private int size;
        private int currentDirectionIndex;

        public Matrix(int size)
        {
            this.Size = size;
            this.Field = new int[size, size];
            this.directions = new[]{
                                      new Cell(1, 1), new Cell(1, 0), new Cell(1, -1), new Cell(0, -1),
                                      new Cell(-1, -1),new Cell(-1, 0), new Cell(-1, 1), new Cell(0, 1)
                                   };
            this.numberOfDirections = directions.Length;
            this.currentDirectionIndex = 0;
            this.FillMatrix();
        }

        public int[,] Field { get; private set; }

        private int Size
        {
            set
            {
                this.size = value;
            }
        }

        private Cell MoveToFirstEmptyCell()
        {
            Cell result = new Cell(0, 0);

            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    if (this.Field[i, j] == 0)
                    {
                        currentDirectionIndex = 0;
                        result.X = i;
                        result.Y = j;
                        return result;
                    }
                }
            }

            return null;
        }

        private Cell Move(Cell cell)
        {
            for (int i = this.currentDirectionIndex; i < this.currentDirectionIndex + numberOfDirections; i++)
            {
                var nextCell = cell + this.directions[i % numberOfDirections];
                if (this.IsValidDestination(nextCell))
                {
                    this.currentDirectionIndex = i % numberOfDirections;
                    return nextCell;
                }
            }

            return null;
        }

        private bool IsValidDestination(Cell cell)
        {
            return cell.X >= 0 && cell.X < this.size &&
                   cell.Y >= 0 && cell.Y < this.size && 
                   this.Field[cell.X, cell.Y] == 0;
        }

        private void FillMatrix()
        {
            var currentCell = new Cell(0, 0);
            var currentCellValue = 1;

            while (currentCellValue <= this.size * this.size)
            {
                this.Field[currentCell.X, currentCell.Y] = currentCellValue;
                currentCell = this.Move(currentCell) ?? this.MoveToFirstEmptyCell();

                //if (currentCell == null)
                //{
                //    currentCell = this.FindFirstEmptyCell();
                //}

                currentCellValue++;
            }
        }

        public override string ToString()
        {
            var matrixOutput = new StringBuilder();
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    matrixOutput.AppendFormat("{0,4}", this.Field[i, j]);
                }

                matrixOutput.Append(Environment.NewLine);
            }

            return matrixOutput.ToString();
        }
    }
}