using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    public class Quiz
    {
        public string name;
        public List<Module> modules = new List<Module>();

        public Quiz()
        {
            name = "New Quiz";
        }

        public Quiz(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
