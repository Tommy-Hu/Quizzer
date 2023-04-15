using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    public class QuestionPool
    {
        private int currentIteration = 1;
        private SortedSet<Question> questions = new SortedSet<Question>();
        private Random random;

        public int CurrentIteration { get => currentIteration; }

        public QuestionPool(int startingSeed)
        {
            random = new Random(startingSeed);
        }

        /// <summary>
        /// Adds or modifies the specified question so that it appears correct in the pool.
        /// </summary>
        /// <param name="question"></param>
        public void AddOrModify(Question question, float modifyTo)
        {
            if (questions.Contains(question))
                questions.Remove(question);
            question.SetKnowledge(modifyTo);
            questions.Add(question);
        }

        public void AddAll(IEnumerable<Question> questions)
        {
            foreach (Question question in questions)
                this.questions.Add(question);
        }

        public void Clear()
        {
            this.questions.Clear();
        }

        public void RemoveQuestion(Question question)
        {
            if (questions.Contains(question))
                questions.Remove(question);
        }

        private int GetSmallestSeenTime()
        {
            int res = int.MaxValue;
            foreach (Question question in questions)
            {
                res = Math.Min(res, question.lastSeenTime);
            }
            return res;
        }

        public Question? NextQuestion()
        {
            if (questions.Count <= 0) return null;
            else if (questions.Count == 1)
                foreach (Question question in questions) return question;

            int smallestLastSeen = GetSmallestSeenTime();
            int iterationsElapsedSinceSmallest = currentIteration - smallestLastSeen;
            Question? res = null;
            foreach (Question question in questions)
            {
                int iterationsElapsed = currentIteration - question.lastSeenTime;
                float iterationBias = (float)iterationsElapsed / iterationsElapsedSinceSmallest;
                double percentage = random.NextDouble();
                float knowledgeBias = MathF.Pow(question.Knowledge, 2f);//higher knowledge means less chance.
                if (percentage * knowledgeBias <= iterationBias)
                {
                    res = question;
                    break;
                }
            }
            currentIteration++;
            return res;
        }

        public void FinishQuestion(Question question, float multiplier)
        {
            question.lastSeenTime = currentIteration;
            AddOrModify(question, question.Knowledge * multiplier);
        }
    }
}
