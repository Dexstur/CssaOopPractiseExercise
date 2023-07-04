using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcsaModel
{
    public abstract class Human
    {
        public Human()
        {

        }
        public Human(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public Course Course { get; set; }
        public void AttendClass(Weekdays day)
        {
            if(day == Weekdays.Tuesday || day == Weekdays.Thursday)
            {
                Console.WriteLine($"name: {Name}; course: {Course.Name}; day: {day}\n The host will let you in shortly");
                Console.WriteLine();
            }
            else if (Course is BackEnd && day == Weekdays.Monday)
            {
                Console.WriteLine($"name: {Name}; course: {Course.Name}; day: {day}\n The host will let you in shortly");
                Console.WriteLine();
            }
            else if(Course is FrontEnd && day == Weekdays.Wednesday)
            {
                Console.WriteLine($"name: {Name}; course: {Course.Name}; day: {day}\n The host will let you in shortly");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"name: {Name}; course: {Course.Name}; day: {day}\n No class today");
                Console.WriteLine();
            }

            
        }
        public virtual void AskQuestion(Human person)
        {
            Console.WriteLine($"{Name} asked {person.Name} a question");
        }
        public virtual void AnswerQuestion()
        {
            Console.WriteLine($"{Name} answered question");
        }
        
    }

}
