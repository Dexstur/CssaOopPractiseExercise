using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcsaModel
{
    public class Student : Human
    {
        public Student(string name)
        {
            Name = name;
        }

        public override void AskQuestion(Human person)
        {
            base.AskQuestion(person);
        }
        public override void AnswerQuestion()
        {
            base.AnswerQuestion();
        }
        
    }
}
