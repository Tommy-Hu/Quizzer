namespace Quizzer
{
    partial class AddModuleWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_questions = new System.Windows.Forms.Label();
            this.rtb_questions = new System.Windows.Forms.RichTextBox();
            this.rtb_answers = new System.Windows.Forms.RichTextBox();
            this.lbl_answers = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(60, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.PlaceholderText = "Enter name...";
            this.txt_name.Size = new System.Drawing.Size(162, 23);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_questions
            // 
            this.lbl_questions.AutoSize = true;
            this.lbl_questions.Location = new System.Drawing.Point(12, 39);
            this.lbl_questions.Name = "lbl_questions";
            this.lbl_questions.Size = new System.Drawing.Size(209, 15);
            this.lbl_questions.TabIndex = 2;
            this.lbl_questions.Text = "Create questions from lines (optional):";
            // 
            // rtb_questions
            // 
            this.rtb_questions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_questions.Location = new System.Drawing.Point(12, 57);
            this.rtb_questions.Name = "rtb_questions";
            this.rtb_questions.Size = new System.Drawing.Size(210, 151);
            this.rtb_questions.TabIndex = 3;
            this.rtb_questions.Text = "";
            // 
            // rtb_answers
            // 
            this.rtb_answers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_answers.Location = new System.Drawing.Point(12, 229);
            this.rtb_answers.Name = "rtb_answers";
            this.rtb_answers.Size = new System.Drawing.Size(210, 151);
            this.rtb_answers.TabIndex = 5;
            this.rtb_answers.Text = "";
            // 
            // lbl_answers
            // 
            this.lbl_answers.AutoSize = true;
            this.lbl_answers.Location = new System.Drawing.Point(12, 211);
            this.lbl_answers.Name = "lbl_answers";
            this.lbl_answers.Size = new System.Drawing.Size(200, 15);
            this.lbl_answers.TabIndex = 4;
            this.lbl_answers.Text = "Create answers from lines (optional):";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 386);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(99, 33);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(123, 386);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 33);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddModuleWindow
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(231, 431);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.rtb_answers);
            this.Controls.Add(this.lbl_answers);
            this.Controls.Add(this.rtb_questions);
            this.Controls.Add(this.lbl_questions);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddModuleWindow";
            this.Text = "Add Module...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddModuleWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private TextBox txt_name;
        private Label lbl_questions;
        private RichTextBox rtb_questions;
        private RichTextBox rtb_answers;
        private Label lbl_answers;
        private Button btn_ok;
        private Button btn_cancel;
    }
}