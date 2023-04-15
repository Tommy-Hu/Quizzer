using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class AddQuizWindow : Form
    {
        private string? quizName;
        public string? QuizName => quizName;

        public AddQuizWindow()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text == null)
            {
                quizName = null;
                return;
            }
            Regex regex = new Regex("[^a-zA-Z0-9 \\-_\\.]");
            txt_name.Text = regex.Replace(txt_name.Text, "");
            quizName = txt_name.Text;
        }

        private void AddQuizWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
