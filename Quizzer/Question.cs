using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    public class Question : IComparable<Question>
    {
        public string question = "";
        public string answer = "";
        /// <summary>
        /// When this value is 0, this question is guarenteed to be the next question as long as this question has the least knowledge. Otherwise, lower values of lastSeenTime means more likely to be shown next.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int lastSeenTime = 0;

        [Newtonsoft.Json.JsonProperty]
        /// <summary>
        /// Value between 0f and 1f, 0 being excuse me and 1 being 2 ez.
        /// </summary>
        private float knowledge = 0.5f;
        public float Knowledge { get => knowledge; private set => knowledge = MathF.Min(MathF.Max(0.01f, value), 1f); }

        public Question()
        {

        }

        public Question(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public int CompareTo(Question? other)
        {
            if (other == null) return -1;
            int res = Math.Sign(this.Knowledge - other.Knowledge);
            if (res == 0) return question.CompareTo(other.question);
            return res;
        }

        /// <summary>
        /// Note that this should only be called by <seealso cref="QuestionPool"/>
        /// </summary>
        /// <param name="knowledge"></param>
        public void SetKnowledge(float knowledge)
        {
            this.Knowledge = knowledge;
        }
    }
}
