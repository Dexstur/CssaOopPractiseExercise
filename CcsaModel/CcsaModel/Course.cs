using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcsaModel
{
    public abstract class Course
    {
        public List<Student> students { get; set; } = new List<Student>();
        public List<Facilitator> facilitators { get; set; } = new List<Facilitator>();
        public string Name { get; set; }
        public void AddStudent(Student student)
        {
            if(student.Course == null)
            {
                students.Add(student);
                student.Course = this;
            }
            
        }
        public void AddFacilitator(Facilitator facilitator)
        {
            if(facilitator.Course == null)
            {
                facilitators.Add(facilitator);
                facilitator.Course = this;
            }
        }
    }
}
