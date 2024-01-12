using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TFQuestion : Question
    {
        public override string Header => "True or False question";

        public TFQuestion()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1, "True");
            AnswerList[1] = new Answer(2, "False");

        }
        public override void AddQuestion()
        {
            Console.WriteLine(Header);

            /*Body */

            Console.WriteLine("Please enter Body of Question:");
            Body = Console.ReadLine();

            /*Marks*/
            int mark;
            do
            {
                Console.WriteLine("Please enter Marks of Question:");

            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

            Marks = mark;

            /* Right Answer*/

            int RightAnswerId;
            do
            {
                Console.WriteLine("please enter id of right answer");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId < 1 ||
            RightAnswerId > 2);

            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;

            Console.Clear();
        }
    }
}
