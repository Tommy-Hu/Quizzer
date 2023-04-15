﻿// MIT License
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

using System.Text.RegularExpressions;

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
