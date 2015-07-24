namespace Chef
{
    public abstract class Vegetable
    {
        protected Vegetable()
        {
            this.IsRotten = false;
            this.HasNotBeenPeeled = true;
            this.IsCut = false;
            this.IsCooked = false;
        }

        public bool IsRotten { get; set; }

        public bool HasNotBeenPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.HasNotBeenPeeled = false;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }
    }
}
