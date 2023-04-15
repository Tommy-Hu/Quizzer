// MIT License
//
// Copyright (c) 2023 Tommy Hu
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//

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
