using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
    public class TrueFalseQuestion : Question
    {
        // This class represents a True/False question and inherits from Question.
        public TrueFalseQuestion(string body, int mark, int rightAnswerId)
            : base(
                "True | False Question",
                body,
                mark,
                new Answer[]
                {
                    new Answer(1, "True"),
                    new Answer(2, "False")
                })
        {
            RightAnswer = AnswerList[rightAnswerId - 1];
        }
        
        //True and False answers are created automatically msh hdkhlhom manul zy mcq, 3shan hya fixed choices
        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}: Mark {Mark}");

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"{AnswerList[i].AnswerId}- {AnswerList[i].AnswerText}");
            }
        }
    }
}
