namespace RangeExceptions
{
    using System;

    class InvalidRangeException <T> : ApplicationException
    {
        private T start;
        private T end;


        public InvalidRangeException(T start, T end)
            : this(string.Empty, start, end)
        {
        }

        public InvalidRangeException(string message, T start, T end) : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start 
        { 
            get { return this.start;  }
            set { this.start = value; }
        }

        public T End 
            { 
            get { return this.end;  }
            set { this.end = value; }
        }

        public override string Message
        {
            get
            {
                return string.Format("Invalid range. The valid range is within [{0} ... {1}]", this.Start, this.End);
            }         
        }
    }
}
