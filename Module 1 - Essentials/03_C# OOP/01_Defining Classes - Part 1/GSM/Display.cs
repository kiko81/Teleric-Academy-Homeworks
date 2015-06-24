namespace GSM
{
    using System;
    public class Display
    {
        decimal size;
        int numberOfColors;


        public Display()
        {
        }

        public Display(decimal size, int colors)
        {
            this.Size = size;
            this.NumberOfColors = colors;
        }

        public decimal Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value > 2) this.size = value;
                else throw new ArgumentException("Size > 2 inches");
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            private set
            {
                if (value > 0) this.numberOfColors = value;
                else throw new ArgumentException("At least 1 color");
            }
        }

        public override string ToString()
        {
            return string.Format("Size: {0}, Colors: {1}", this.Size, this.NumberOfColors);
        }

    }
}
