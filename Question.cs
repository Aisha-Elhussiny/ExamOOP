using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
   public abstract class Question
    {
        //3mlt class abstract 3shan kol question lazem y3ml override ll display question method 3la hasb no3o
        //homa msh kolhom wahed 
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }

  
        public Answer RightAnswer { get; set; } = new Answer(0, "");
        //3mlt default value 3shan null error


        public Question(string header, string body, int mark, Answer[] answerList)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
        }

        public abstract void DisplayQuestion();
        //kol question lazem y3ml override ll display question method 3la hasb no3o
    }
}
