using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcsaModel
{
    public class Facilitator : Human
    {
        public Facilitator(string name) 
        {
            Name = name;
        }
        public override void AskQuestion(Human person)
        {
            if(person is Student)
            {
                base.AskQuestion(person);
            }
        }
        public override void AnswerQuestion()
        {
            base.AnswerQuestion();
            Console.WriteLine($"{Name} provided extra resources");
        }
    }
}
