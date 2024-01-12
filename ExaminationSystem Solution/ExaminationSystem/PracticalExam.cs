using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticalExam : Exam
    {

          /*MCQ*/
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new MCQQuestion[NumberOfQuestions];
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                ListOfQuestions[i] = new MCQQuestion();
                ListOfQuestions[i].AddQuestion();
                Console.Clear();
            }
        }

        public override void ShowExam()
        {
            
            foreach (var Question  in ListOfQuestions)
            {
                Console.WriteLine(Question);
                for (int i = 0; i < Question.AnswerList.Length; i++)
                {
                    Console.WriteLine(Question.AnswerList[i]);
                }
                Console.WriteLine("---------------------------");

                int UserAnswerId;
                do
                {
                    Console.WriteLine("enter number of you answer:");

                }
                while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 ||
                    UserAnswerId > 3);

               

                Console.WriteLine("-----------------");
            }
            Console.Clear() ;

            Console.WriteLine("righ answers:");
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                Console.WriteLine($"right answer of question {i+1} : " +
                    $"{ListOfQuestions[i].RightAnswer.AnswerText}");
            }
        }
    }
}
