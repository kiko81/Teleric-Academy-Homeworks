namespace TheStore.Models.Sql
{
    using System.ComponentModel.DataAnnotations;

    public class LaptopClass
    {
        public int Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }    
    }
}
