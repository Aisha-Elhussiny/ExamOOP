using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
   internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam? SubjectExam { get; set; }
        //3mlt ? 3shan el exam msh lazem ykon mwgod f el awl , ana b3ml l subject w b3dha l exam
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(Exam exam)
        {
            SubjectExam = exam;
            //da kda shayel prac aw final
        }
        // This method allows you to assign an exam to the subject after the subject has been created.
    }
}
