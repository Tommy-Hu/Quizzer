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
