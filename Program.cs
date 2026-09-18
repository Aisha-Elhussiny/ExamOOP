using System;

namespace ExamOOP
{
internal class Program
    {

        /*
         * bkhtsar ana 3ndi subject gowah exam w kol exam gowah questions w kol question gowah answers
         * 3ndi no3en mn el exam Practical w Final
         * w 3ndi no3en mn el question MCQ w TrueFalse
         */
        static void Main()
        {
            int mark;
            bool isParsed;
            int questionType;
            int examType;
            int examTime;
            int numberOfQuestions;
            int rightAnswerId;
            string startExam;

            Subject subject = new Subject(1, "OOP");
            //hna 3mlt object mn el class Subject w 3mltlo id w esm

            do
            {
                Console.WriteLine("Enter the type of exam:");
                Console.WriteLine("1 for Practical, 2 for Final");

                isParsed = int.TryParse(Console.ReadLine(), out examType);
            } while (!isParsed || examType < 1 || examType > 2);
      

            do
            {
                Console.WriteLine("Please enter the time for the exam (30 to 180 minutes):");
                isParsed = int.TryParse(Console.ReadLine(), out examTime);

            } while (!isParsed || examTime < 30 || examTime > 180);

            do
            {
                Console.WriteLine("Please enter the number of questions:");

                isParsed = int.TryParse(Console.ReadLine(), out numberOfQuestions);

            } while (!isParsed || numberOfQuestions <= 0);


            Exam exam;


            if (examType == 1)
            {
                exam = new PracticalExam(examTime, numberOfQuestions);
            }
            else
            {
                exam = new FinalExam(examTime, numberOfQuestions);
            }

            subject.CreateExam(exam);
            //3shan a7dd no3 el exam
            //by7ot el exam elly 3mlto f el subject

            Console.Clear();

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"Enter details for question {i + 1}");


                if (examType == 1)
                {
                    questionType = 1;
                  
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Choose question type:");
                        Console.WriteLine("1 for MCQ, 2 for True/False");

                        isParsed = int.TryParse(Console.ReadLine(), out questionType);
                    } while (!isParsed || questionType < 1 || questionType > 2);
                }
              

                Console.WriteLine("Please enter the question body:");
                string body = Console.ReadLine() ?? "";

                do
                {
                    Console.WriteLine("Please enter the question mark:");

                    isParsed = int.TryParse(Console.ReadLine(), out mark);

                } while (!isParsed || mark <= 0);

                if (questionType == 1)
                {
                    Answer[] answers = new Answer[4];

                    Console.WriteLine("\nChoices of Question:");

                    for (int j = 0; j < answers.Length; j++)
                    {
                        Console.WriteLine($"Please enter choice number {j + 1}:");
                        string choice = Console.ReadLine() ?? "";

                        answers[j] = new Answer(j + 1, choice);
                    }

                    do
                    {
                        Console.WriteLine("Please enter the ID of the correct answer:");
                        Console.WriteLine("Choose a number from 1 to 4.");

                        isParsed = int.TryParse(Console.ReadLine(), out rightAnswerId);

                    } while (!isParsed || rightAnswerId < 1 || rightAnswerId > 4);

                    exam.Questions[i] = new MCQQuestion(
                        body,
                        mark,
                        answers,
                        rightAnswerId
                    );
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Please enter the ID of the correct answer:");
                        Console.WriteLine("1 for True, 2 for False");

                        isParsed = int.TryParse(Console.ReadLine(), out rightAnswerId);

                    } while (!isParsed || rightAnswerId < 1 || rightAnswerId > 2);




                    exam.Questions[i] = new TrueFalseQuestion(
                        body,
                        mark,
                        rightAnswerId
                    );
                }

                Console.WriteLine();
            }

            Console.Clear();
            

            do
            {
                Console.WriteLine("Do You Want To Start Exam?");
                Console.WriteLine("Y for Yes, N for No");

                startExam = (Console.ReadLine() ?? "").Trim().ToUpper();
                //3shan lw 3mlt space aw 7aga y3ml trim w lw 3mlt lower case y3ml upper case

                if (startExam != "Y" && startExam != "N")
                {
                    Console.WriteLine("Invalid input. Please enter Y or N only.");
                }

            } while (startExam != "Y" && startExam != "N");

            if (startExam == "Y")
            {
                subject.SubjectExam?.ShowExam();
            }
            else
            {
                Console.WriteLine("Exam was not started.");
            }

        }
    }
}