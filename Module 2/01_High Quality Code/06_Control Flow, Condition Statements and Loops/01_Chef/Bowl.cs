namespace Chef
{
    using System.Collections.Generic;

    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegetable>();
        }

        public ICollection<Vegetable> Ingredients { get; set; }

        public void Add(Vegetable vegetable)
        {
            this.Ingredients.Add(vegetable);
        }

        public void Cook()
        {
            //Addition
            foreach (var ingredient in this.Ingredients)
            {
                ingredient.Cook();
            }
        }
    }
}