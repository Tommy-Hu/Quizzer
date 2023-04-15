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

using System.Data;

namespace Quizzer
{
    public partial class AddModuleWindow : Form
    {
        private string moduleName = "";
        private string[] questions = new string[0];
        private string[] answers = new string[0];

        public string ModuleName { get => moduleName; }
        public string[] Questions { get => questions; }
        public string[] Answers { get => answers; }

        public AddModuleWindow()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            moduleName = txt_name.Text;
            if (moduleName == null)
            {
                MessageBox.Show("Please enter a valid module name!");
                return;
            }
            questions = rtb_questions.Text?.Split("\n", StringSplitOptions.TrimEntries) ?? new string[0];
            answers = rtb_answers.Text?.Split("\n", StringSplitOptions.TrimEntries) ?? new string[0];

            if (questions.Length > answers.Length)
            {
                var res = MessageBox.Show(
                    $"There are {questions.Length} questions but only {answers.Length} answers!\n" +
                    $"The rest of the questions will have no answer (you can edit them later)!", "Warning!", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    //extend the answers array so that questions and answers match in length.
                    Array.Resize(ref answers, questions.Length);
                    answers = answers.Select((original) => original ?? "").ToArray();//map all null to ""

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else if (questions.Length < answers.Length)
            {
                var res = MessageBox.Show(
                    $"There are {questions.Length} questions but {answers.Length} answers!\n" +
                    $"The rest of the answers will be truncated!", "Warning!", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    //cut the answers array so that questions and answers match in length.
                    answers = answers.Take(questions.Length).ToArray();

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddModuleWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
