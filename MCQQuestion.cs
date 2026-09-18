using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
   public class MCQQuestion : Question
    {
        public MCQQuestion(string body, int mark, Answer[] answerList, int rightAnswerId)
            : base("MCQ Question", body, mark, answerList)
        {
            RightAnswer = AnswerList[rightAnswerId - 1];
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}: Mark {Mark}");

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"{AnswerList[i].AnswerId}- {AnswerList[i].AnswerText}");
            }
            //hy3ml display l kol mcq answer choices
        }
    }
}
