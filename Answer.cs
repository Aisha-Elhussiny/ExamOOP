using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
   public class Answer
    {
        //da class by3ml one  answer choice for a question
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        //3mlt constructor 3shan a3ml object mn el class da w a7ot el values bta3to
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
    }
}
