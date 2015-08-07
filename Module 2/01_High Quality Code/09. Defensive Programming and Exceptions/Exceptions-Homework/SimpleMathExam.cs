namespace Exceptions_Homework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                int checkedValue;

                if(value < 0)
                {
                    checkedValue = MinProblemsSolved;
                }
                else if(value > 10)
                {
                    checkedValue = MaxProblemsSolved;
                }
                else
                {
                    checkedValue = value;
                }

                this.problemsSolved = checkedValue;
            }
        }

        public override ExamResult Check()
        {
            if (ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else if(ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else
            {
                throw new ArgumentException("Invalid number of problems solved!");
            }

            //return new ExamResult(0, 0, 1, "Invalid number of problems solved!");
        }
    }
}
