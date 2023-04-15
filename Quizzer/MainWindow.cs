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

using Imaginary.Core.IO;

namespace Quizzer
{
    public partial class MainWindow : Form
    {
        public QuestionPool questionPool;
        public Question? currentQuestion;

        public MainWindow()
        {
            InitializeComponent();
            questionPool = new QuestionPool(Environment.TickCount);
        }

        private string RootPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Imaginary/Quizzer/");
        private Quiz? SelectedQuiz => lbox_quizzes.SelectedItem as Quiz;

        private string GetPath(string quizName)
        {
            return Path.Combine(RootPath, quizName + ".json");
        }

        private void SaveQuiz(Quiz quiz)
        {
            Writer.WriteJsonFullPath(quiz, GetPath(quiz.name));
        }

        private void ReloadQuizzes()
        {
            lbox_quizzes.Items.Clear();
            lbox_modules.Items.Clear();
            questionPool.Clear();
            currentQuestion = null;
            Directory.CreateDirectory(RootPath);
            foreach (string filePath in Directory.EnumerateFiles(RootPath))
            {
                Quiz q = Reader.ReadJsonFullPath<Quiz>(filePath);
                lbox_quizzes.Items.Add(q);
            }
            if (lbox_quizzes.Items.Count > 0)
            {
                lbox_quizzes.SelectedIndex = 0;
                lbox_quizzes_SelectedIndexChanged(null, null);
                btn_delQuiz.Enabled = true;
                btn_addModule.Enabled = true;
            }
            else
            {
                btn_delQuiz.Enabled = false;
                btn_addModule.Enabled = false;
                btn_delModule.Enabled = false;
                DisplayNextQuestion();//this will disable all the rest of the buttons since there's nothing in question pool.
            }
        }

        private void ReloadModules()
        {
            lbox_modules.Items.Clear();
            questionPool.Clear();
            currentQuestion = null;
            Quiz? cur = SelectedQuiz;
            if (cur != null)
            {
                foreach (Module module in cur.modules)
                {
                    lbox_modules.Items.Add(module);
                }
                if (lbox_modules.Items.Count > 0)
                {
                    lbox_modules.SelectedIndex = 0;
                    lbox_modules_SelectedIndexChanged(null, null);
                    btn_delModule.Enabled = true;
                }
                else
                {
                    btn_delModule.Enabled = false;
                }
                DisplayNextQuestion();//this will disable all the rest of the buttons when there's nothing in question pool.
            }
        }

        private void btn_reveal_Click(object sender, EventArgs e)
        {
            btn_reveal.Visible = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ReloadQuizzes();
        }

        private void lbox_quizzes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadModules();
        }

        private void btn_delQuiz_Click(object sender, EventArgs e)
        {
            if (SelectedQuiz == null) return;
            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    File.Delete(GetPath(SelectedQuiz.name));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n" + ex);
                }
                finally
                {
                    ReloadQuizzes();
                }
            }
        }

        private void btn_addQuiz_Click(object sender, EventArgs e)
        {
            AddQuizWindow addQuizWindow = new AddQuizWindow();
            if (addQuizWindow.ShowDialog() == DialogResult.OK)
            {
                string? quizName = addQuizWindow.QuizName;
                if (quizName != null)
                {
                    if (File.Exists(GetPath(quizName)))
                    {
                        MessageBox.Show("A quiz with the same name already exists!");
                    }
                    else
                    {
                        Writer.WriteJsonFullPath(new Quiz(quizName), GetPath(quizName));
                        ReloadQuizzes();
                    }
                }
                else MessageBox.Show("Please enter a valid quiz name!");
            }
            addQuizWindow.Dispose();
        }

        private void btn_delModule_Click(object sender, EventArgs e)
        {
            Quiz? selectedQuiz = SelectedQuiz;
            if (selectedQuiz != null)
            {
                int n = lbox_modules.SelectedIndices.Count;
                int[] selectedIndicesSorted = new int[n];
                for (int i = 0; i < n; i++)
                {
                    selectedIndicesSorted[i] = lbox_modules.SelectedIndices[i];
                }
                Array.Sort(selectedIndicesSorted);
                for (int i = n - 1; i >= 0; i--)
                {
                    int index = selectedIndicesSorted[i];
                    selectedQuiz.modules.RemoveAt(index);
                    lbox_modules.Items.RemoveAt(index);
                }
                SaveQuiz(selectedQuiz);
                ReloadModules();
            }
        }

        private void btn_addModule_Click(object sender, EventArgs e)
        {
            Quiz? selectedQuiz = SelectedQuiz;
            if (selectedQuiz != null)
            {
                AddModuleWindow addModWindow = new AddModuleWindow();
                if (addModWindow.ShowDialog() == DialogResult.OK)
                {
                    string name = addModWindow.ModuleName;

                    Module module = new Module(name);
                    module.questions = new List<Question>();
                    string[] rawQuestions = addModWindow.Questions;
                    string[] rawAnswers = addModWindow.Answers;
                    for (int i = 0; i < rawQuestions.Length; i++)
                    {
                        module.questions.Add(new Question(rawQuestions[i], rawAnswers[i]));
                    }

                    selectedQuiz.modules.Add(module);
                }
                SaveQuiz(selectedQuiz);
                ReloadModules();
            }
        }

        private void lbox_modules_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quiz? selectedQuiz = SelectedQuiz;
            if (selectedQuiz != null)
            {
                questionPool.Clear();
                foreach (Module module in lbox_modules.SelectedItems)
                {
                    questionPool.AddAll(module.questions);
                }
                DisplayNextQuestion();
            }
        }

        private void DisplayNextQuestion()
        {
            currentQuestion = questionPool.NextQuestion();
            if (currentQuestion == null)
            {
                rtb_question.Text = "";
                rtb_answer.Text = "";
                btn_reveal.Enabled = false;
                btn_2ez.Enabled = false;
                btn_ez.Enabled = false;
                btn_meh.Enabled = false;
                btn_idk.Enabled = false;
                btn_excuseMe.Enabled = false;
            }
            else
            {
                rtb_question.Text = currentQuestion.question;
                rtb_answer.Text = currentQuestion.answer;
                btn_reveal.Enabled = true;
                btn_2ez.Enabled = true;
                btn_ez.Enabled = true;
                btn_meh.Enabled = true;
                btn_idk.Enabled = true;
                btn_excuseMe.Enabled = true;
            }
            btn_reveal.Visible = true;
        }

        private void btn_2ez_Click(object sender, EventArgs e)
        {
            FinishAndDisplayNextQuestion(1.5f);
        }

        private void btn_ez_Click(object sender, EventArgs e)
        {
            FinishAndDisplayNextQuestion(1.25f);
        }

        private void btn_meh_Click(object sender, EventArgs e)
        {
            FinishAndDisplayNextQuestion(0.95f);
        }

        private void btn_idk_Click(object sender, EventArgs e)
        {
            FinishAndDisplayNextQuestion(0.5f);
        }

        private void btn_excuseMe_Click(object sender, EventArgs e)
        {
            FinishAndDisplayNextQuestion(0.1f);
        }

        private void FinishAndDisplayNextQuestion(float multiplier)
        {
            if (currentQuestion != null)
                questionPool.FinishQuestion(currentQuestion, multiplier);
            DisplayNextQuestion();

            if (SelectedQuiz != null)
                SaveQuiz(SelectedQuiz);
        }

        private void rtb_answer_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedQuiz != null && currentQuestion != null)
            {
                rtb_answer.ReadOnly = false;
                rtb_answer.BackColor = SystemColors.ControlLightLight;
            }
        }

        private void rtb_answer_Leave(object sender, EventArgs e)
        {
            rtb_answer.ReadOnly = true;
            rtb_answer.BackColor = SystemColors.Control;
            if (SelectedQuiz != null && currentQuestion != null)
            {
                currentQuestion.answer = rtb_answer.Text;
                SaveQuiz(SelectedQuiz);
            }
        }
    }
}