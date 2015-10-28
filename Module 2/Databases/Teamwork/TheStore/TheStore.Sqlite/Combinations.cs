namespace TheStore.Sqlite
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LaptopMouseCombinations")]
    public class Combinations
    {
        [Key]
        public int Id { get; set; }

        public int LaptopId { get; set; }

        public int MouseId { get; set; }
    }
}
