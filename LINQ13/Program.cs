namespace LINQ13.Shared
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            RunMethod04();
        }
        static void RunMethod01()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);
            var quiz3 = quiz1.Concat(quiz2);
            quiz3.ToQuiz();
        }
        static void RunMethod02()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);
            var questionTitels = quiz1.Select(q => q.Title).Concat(quiz2.Select(q => q.Title));
            foreach (var title in questionTitels)
            {
                Console.WriteLine(title);
            }
        }
        static void RunMethod03()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);
            var quiz3 = QuestionBank.GetQuestionRange(Enumerable.Range(11, 14));
            var questionTitels = quiz1.Select(q => q.Title).Concat(quiz2.Select(q => q.Title)).Concat(quiz3.Select(q => q.Title));
            foreach (var title in questionTitels)
            {
                Console.WriteLine(title);
            }
        }
        static void RunMethod04()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);

            var quiz3 = new[] { quiz1, quiz2 }.SelectMany(q=>q);
            quiz3.ToQuiz();



        }


    }
}