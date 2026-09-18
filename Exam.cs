using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
   public abstract class Exam
    {

        //brdo 3mltha abstract 3shan kol exam y3ml override ll show exam method 3la hasb no3o 
        //3shan brdo howa msh no3 wa7ed
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        // The Questions array can store different question types because they all inherit from Question.3la 7asb ekhtrt anhy no3 
        public Exam(int time, int numberOfQuestions)
        {
            //el constructor da by3ml initialize ll properties bta3t el exam w by3ml allocate ll array bta3t el questions 3la 7asb el number of questions elly 3mlt leha passing 
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
        }

        public abstract void ShowExam();
        // Each exam type must implement its own way of showing questions and results.
    }
}
