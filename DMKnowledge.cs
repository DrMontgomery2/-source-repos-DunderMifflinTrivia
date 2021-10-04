using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace DunderMifflinTrivia
{
    class DMKnowledge
    {
        private string Question;
        private string Answers;

        public DMKnowledge(string dmquestion, string dmanswer)//these are parameters "string dmquestion, string dmanswer"
        {

            Question = dmquestion;
            Answers = dmanswer;
        }

        public void AskTheQuestion()
        {
            WriteLine(Question);
            Write("Answers:");
            string playerAnswer = ReadLine();

            WriteLine($"Your response was '{playerAnswer}'.");
            WriteLine($"The correct answer is: {Answers}");
            if (playerAnswer == "true")
            {
                WriteLine("That is correct!");
                WriteLine("You are getting close to that Dundie!");
            }
            else
            {
                WriteLine("Your answer is incorrect!");
                WriteLine("You really Schruted it!");
            }

            //Display the question, get reponse, and display corrrect answer
        }

    }

}
