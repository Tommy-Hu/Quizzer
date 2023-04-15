using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    public class Module
    {
        public string name;
        public List<Question> questions = new List<Question>();

        public Module()
        {
            this.name = "New Module";
        }

        public Module(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
