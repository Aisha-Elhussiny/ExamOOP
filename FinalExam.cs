using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExamOOP
{
   internal class FinalExam : Exam
    {
        // This class represents a final exam and supports different question types.
        int answerId;
        bool isParsed;

        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            int totalGrade = 0;
            int studentGrade = 0;

            Answer[] studentAnswers = new Answer[NumberOfQuestions];
            Stopwatch stopwatch = new Stopwatch();


            Console.Clear();
            Console.WriteLine("Final Exam");
            stopwatch.Start();


            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {Questions[i].Body}");

                Questions[i].DisplayQuestion();

                do
                {
                    Console.WriteLine("Enter your answer ID:");

                    isParsed = int.TryParse(Console.ReadLine(), out answerId);


                } while (!isParsed || answerId < 1 || answerId > Questions[i].AnswerList.Length);

                studentAnswers[i] = Questions[i].AnswerList[answerId - 1];
                //bkhzn l answer

                totalGrade += Questions[i].Mark;

                if (studentAnswers[i].AnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    studentGrade += Questions[i].Mark;
                }
            }
            stopwatch.Stop();
            Console.Clear();

            Console.WriteLine("Final Exam Results:");

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
        // This method displays the final exam questions and shows the student's result.
    }
}
