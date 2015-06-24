namespace School
{
    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLections, numberOfExercises;

        public string Name { get; set; }

        public int NumberOfLections { get; set; }

        public int NumberOfExercises { get; set; }

        public string Comment { set; }
    }
}
