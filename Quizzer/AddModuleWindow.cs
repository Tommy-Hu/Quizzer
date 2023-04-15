using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
