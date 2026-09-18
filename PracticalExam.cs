using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExamOOP
{
    internal class PracticalExam : Exam
    {
        // This class represents a practical exam and inherits the common exam data.
        public PracticalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            int totalGrade = 0;
            int studentGrade = 0;

            Answer[] studentAnswers = new Answer[NumberOfQuestions];
            //b3ml array bnfs el size bta3 el number of questions 3ashan a7ot feha el answers bta3t el student
            Stopwatch stopwatch = new Stopwatch();
            Console.Clear();
            Console.WriteLine("Practical Exam");
            stopwatch.Start();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {Questions[i].Body}");

                Questions[i].DisplayQuestion();
                //kol question object ht3ml display l nfsha 3la hasb el actual type bta3ha

                Console.WriteLine("Enter your answer ID:");
                int answerId = int.Parse(Console.ReadLine() ?? "0");

                studentAnswers[i] = Questions[i].AnswerList[answerId - 1];


                totalGrade += Questions[i].Mark;

                if (studentAnswers[i].AnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    studentGrade += Questions[i].Mark;
                }
            }
            // This method displays the practical exam, stores student answers, and calculates the final grade.
            stopwatch.Stop();
            Console.Clear();

            Console.WriteLine("Practical Exam Results:");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Your Answer => {studentAnswers[i].AnswerText}");
                Console.WriteLine($"Correct Answer => {Questions[i].RightAnswer.AnswerText}");
            }

            Console.WriteLine($"\nYour Grade is {studentGrade} from {totalGrade}");
            Console.WriteLine($"Time = {stopwatch.Elapsed}");

            Console.WriteLine("Thank you");
        }

    }
}
