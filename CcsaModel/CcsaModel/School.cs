using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcsaModel
{
    public class School
    {
        public School(string name) 
        {
            Name = name;
        }
        public string Name { get; set; }

        public Course Course1 { get; set; }
        public Course Course2 { get; set; }
    }
}
