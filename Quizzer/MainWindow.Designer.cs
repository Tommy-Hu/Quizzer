namespace Quizzer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_content = new System.Windows.Forms.GroupBox();
            this.pn_answerBorder = new System.Windows.Forms.Panel();
            this.btn_reveal = new System.Windows.Forms.Button();
            this.rtb_answer = new System.Windows.Forms.RichTextBox();
            this.btn_stats = new System.Windows.Forms.Button();
            this.gbox_actions = new System.Windows.Forms.GroupBox();
            this.btn_excuseMe = new System.Windows.Forms.Button();
            this.btn_idk = new System.Windows.Forms.Button();
            this.btn_meh = new System.Windows.Forms.Button();
            this.btn_ez = new System.Windows.Forms.Button();
            this.btn_2ez = new System.Windows.Forms.Button();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.lbl_question = new System.Windows.Forms.Label();
            this.gbox_modules = new System.Windows.Forms.GroupBox();
            this.btn_delModule = new System.Windows.Forms.Button();
            this.btn_addModule = new System.Windows.Forms.Button();
            this.lbox_modules = new System.Windows.Forms.ListBox();
            this.gbox_quizzes = new System.Windows.Forms.GroupBox();
            this.btn_delQuiz = new System.Windows.Forms.Button();
            this.btn_addQuiz = new System.Windows.Forms.Button();
            this.lbox_quizzes = new System.Windows.Forms.ListBox();
            this.gbox_content.SuspendLayout();
            this.pn_answerBorder.SuspendLayout();
            this.gbox_actions.SuspendLayout();
            this.gbox_modules.SuspendLayout();
            this.gbox_quizzes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_content
            // 
            this.gbox_content.Controls.Add(this.pn_answerBorder);
            this.gbox_content.Controls.Add(this.btn_stats);
            this.gbox_content.Controls.Add(this.gbox_actions);
            this.gbox_content.Controls.Add(this.lbl_answer);
            this.gbox_content.Controls.Add(this.rtb_question);
            this.gbox_content.Controls.Add(this.lbl_question);
            this.gbox_content.Location = new System.Drawing.Point(308, 12);
            this.gbox_content.Name = "gbox_content";
            this.gbox_content.Size = new System.Drawing.Size(480, 426);
            this.gbox_content.TabIndex = 7;
            this.gbox_content.TabStop = false;
            // 
            // pn_answerBorder
            // 
            this.pn_answerBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_answerBorder.Controls.Add(this.btn_reveal);
            this.pn_answerBorder.Controls.Add(this.rtb_answer);
            this.pn_answerBorder.Location = new System.Drawing.Point(6, 173);
            this.pn_answerBorder.Name = "pn_answerBorder";
            this.pn_answerBorder.Size = new System.Drawing.Size(468, 115);
            this.pn_answerBorder.TabIndex = 7;
            // 
            // btn_reveal
            // 
            this.btn_reveal.Location = new System.Drawing.Point(-1, -1);
            this.btn_reveal.Name = "btn_reveal";
            this.btn_reveal.Size = new System.Drawing.Size(468, 115);
            this.btn_reveal.TabIndex = 4;
            this.btn_reveal.Text = "Click to reveal answer";
            this.btn_reveal.UseVisualStyleBackColor = true;
            this.btn_reveal.Click += new System.EventHandler(this.btn_reveal_Click);
            // 
            // rtb_answer
            // 
            this.rtb_answer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_answer.Location = new System.Drawing.Point(0, 0);
            this.rtb_answer.Name = "rtb_answer";
            this.rtb_answer.ReadOnly = true;
            this.rtb_answer.Size = new System.Drawing.Size(466, 113);
            this.rtb_answer.TabIndex = 3;
            this.rtb_answer.Text = "";
            this.rtb_answer.DoubleClick += new System.EventHandler(this.rtb_answer_DoubleClick);
            this.rtb_answer.Leave += new System.EventHandler(this.rtb_answer_Leave);
            // 
            // btn_stats
            // 
            this.btn_stats.Location = new System.Drawing.Point(6, 359);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(468, 61);
            this.btn_stats.TabIndex = 6;
            this.btn_stats.Text = "Show stats (not implemented)";
            this.btn_stats.UseVisualStyleBackColor = true;
            // 
            // gbox_actions
            // 
            this.gbox_actions.Controls.Add(this.btn_excuseMe);
            this.gbox_actions.Controls.Add(this.btn_idk);
            this.gbox_actions.Controls.Add(this.btn_meh);
            this.gbox_actions.Controls.Add(this.btn_ez);
            this.gbox_actions.Controls.Add(this.btn_2ez);
            this.gbox_actions.Location = new System.Drawing.Point(6, 294);
            this.gbox_actions.Name = "gbox_actions";
            this.gbox_actions.Size = new System.Drawing.Size(468, 59);
            this.gbox_actions.TabIndex = 5;
            this.gbox_actions.TabStop = false;
            this.gbox_actions.Text = "Difficulty";
            // 
            // btn_excuseMe
            // 
            this.btn_excuseMe.Location = new System.Drawing.Point(354, 22);
            this.btn_excuseMe.Name = "btn_excuseMe";
            this.btn_excuseMe.Size = new System.Drawing.Size(108, 29);
            this.btn_excuseMe.TabIndex = 4;
            this.btn_excuseMe.Text = "Excuse me?";
            this.btn_excuseMe.UseVisualStyleBackColor = true;
            this.btn_excuseMe.Click += new System.EventHandler(this.btn_excuseMe_Click);
            // 
            // btn_idk
            // 
            this.btn_idk.Location = new System.Drawing.Point(267, 22);
            this.btn_idk.Name = "btn_idk";
            this.btn_idk.Size = new System.Drawing.Size(81, 29);
            this.btn_idk.TabIndex = 3;
            this.btn_idk.Text = "Idk";
            this.btn_idk.UseVisualStyleBackColor = true;
            this.btn_idk.Click += new System.EventHandler(this.btn_idk_Click);
            // 
            // btn_meh
            // 
            this.btn_meh.Location = new System.Drawing.Point(180, 22);
            this.btn_meh.Name = "btn_meh";
            this.btn_meh.Size = new System.Drawing.Size(81, 29);
            this.btn_meh.TabIndex = 2;
            this.btn_meh.Text = "Meh";
            this.btn_meh.UseVisualStyleBackColor = true;
            this.btn_meh.Click += new System.EventHandler(this.btn_meh_Click);
            // 
            // btn_ez
            // 
            this.btn_ez.Location = new System.Drawing.Point(93, 22);
            this.btn_ez.Name = "btn_ez";
            this.btn_ez.Size = new System.Drawing.Size(81, 29);
            this.btn_ez.TabIndex = 1;
            this.btn_ez.Text = "EZ";
            this.btn_ez.UseVisualStyleBackColor = true;
            this.btn_ez.Click += new System.EventHandler(this.btn_ez_Click);
            // 
            // btn_2ez
            // 
            this.btn_2ez.Location = new System.Drawing.Point(6, 22);
            this.btn_2ez.Name = "btn_2ez";
            this.btn_2ez.Size = new System.Drawing.Size(81, 29);
            this.btn_2ez.TabIndex = 0;
            this.btn_2ez.Text = "2 EZ";
            this.btn_2ez.UseVisualStyleBackColor = true;
            this.btn_2ez.Click += new System.EventHandler(this.btn_2ez_Click);
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(6, 155);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(227, 15);
            this.lbl_answer.TabIndex = 2;
            this.lbl_answer.Text = "Answer (double click the text box to edit):";
            // 
            // rtb_question
            // 
            this.rtb_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_question.Location = new System.Drawing.Point(6, 37);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.ReadOnly = true;
            this.rtb_question.Size = new System.Drawing.Size(468, 115);
            this.rtb_question.TabIndex = 1;
            this.rtb_question.Text = "";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(6, 19);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(58, 15);
            this.lbl_question.TabIndex = 0;
            this.lbl_question.Text = "Question:";
            // 
            // gbox_modules
            // 
            this.gbox_modules.Controls.Add(this.btn_delModule);
            this.gbox_modules.Controls.Add(this.btn_addModule);
            this.gbox_modules.Controls.Add(this.lbox_modules);
            this.gbox_modules.Location = new System.Drawing.Point(160, 12);
            this.gbox_modules.Name = "gbox_modules";
            this.gbox_modules.Size = new System.Drawing.Size(142, 426);
            this.gbox_modules.TabIndex = 6;
            this.gbox_modules.TabStop = false;
            this.gbox_modules.Text = "Modules";
            // 
            // btn_delModule
            // 
            this.btn_delModule.Location = new System.Drawing.Point(79, 392);
            this.btn_delModule.Name = "btn_delModule";
            this.btn_delModule.Size = new System.Drawing.Size(57, 28);
            this.btn_delModule.TabIndex = 2;
            this.btn_delModule.Text = "Del";
            this.btn_delModule.UseVisualStyleBackColor = true;
            this.btn_delModule.Click += new System.EventHandler(this.btn_delModule_Click);
            // 
            // btn_addModule
            // 
            this.btn_addModule.Location = new System.Drawing.Point(6, 392);
            this.btn_addModule.Name = "btn_addModule";
            this.btn_addModule.Size = new System.Drawing.Size(57, 28);
            this.btn_addModule.TabIndex = 1;
            this.btn_addModule.Text = "Add";
            this.btn_addModule.UseVisualStyleBackColor = true;
            this.btn_addModule.Click += new System.EventHandler(this.btn_addModule_Click);
            // 
            // lbox_modules
            // 
            this.lbox_modules.FormattingEnabled = true;
            this.lbox_modules.ItemHeight = 15;
            this.lbox_modules.Location = new System.Drawing.Point(6, 22);
            this.lbox_modules.Name = "lbox_modules";
            this.lbox_modules.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbox_modules.Size = new System.Drawing.Size(130, 364);
            this.lbox_modules.TabIndex = 0;
            this.lbox_modules.SelectedIndexChanged += new System.EventHandler(this.lbox_modules_SelectedIndexChanged);
            // 
            // gbox_quizzes
            // 
            this.gbox_quizzes.Controls.Add(this.btn_delQuiz);
            this.gbox_quizzes.Controls.Add(this.btn_addQuiz);
            this.gbox_quizzes.Controls.Add(this.lbox_quizzes);
            this.gbox_quizzes.Location = new System.Drawing.Point(12, 12);
            this.gbox_quizzes.Name = "gbox_quizzes";
            this.gbox_quizzes.Size = new System.Drawing.Size(142, 426);
            this.gbox_quizzes.TabIndex = 5;
            this.gbox_quizzes.TabStop = false;
            this.gbox_quizzes.Text = "Quizzes";
            // 
            // btn_delQuiz
            // 
            this.btn_delQuiz.Location = new System.Drawing.Point(79, 392);
            this.btn_delQuiz.Name = "btn_delQuiz";
            this.btn_delQuiz.Size = new System.Drawing.Size(57, 28);
            this.btn_delQuiz.TabIndex = 2;
            this.btn_delQuiz.Text = "Del";
            this.btn_delQuiz.UseVisualStyleBackColor = true;
            this.btn_delQuiz.Click += new System.EventHandler(this.btn_delQuiz_Click);
            // 
            // btn_addQuiz
            // 
            this.btn_addQuiz.Location = new System.Drawing.Point(6, 392);
            this.btn_addQuiz.Name = "btn_addQuiz";
            this.btn_addQuiz.Size = new System.Drawing.Size(57, 28);
            this.btn_addQuiz.TabIndex = 1;
            this.btn_addQuiz.Text = "Add";
            this.btn_addQuiz.UseVisualStyleBackColor = true;
            this.btn_addQuiz.Click += new System.EventHandler(this.btn_addQuiz_Click);
            // 
            // lbox_quizzes
            // 
            this.lbox_quizzes.FormattingEnabled = true;
            this.lbox_quizzes.ItemHeight = 15;
            this.lbox_quizzes.Location = new System.Drawing.Point(6, 22);
            this.lbox_quizzes.Name = "lbox_quizzes";
            this.lbox_quizzes.Size = new System.Drawing.Size(130, 364);
            this.lbox_quizzes.TabIndex = 0;
            this.lbox_quizzes.SelectedIndexChanged += new System.EventHandler(this.lbox_quizzes_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_content);
            this.Controls.Add(this.gbox_modules);
            this.Controls.Add(this.gbox_quizzes);
            this.Name = "MainWindow";
            this.Text = "Quizzer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbox_content.ResumeLayout(false);
            this.gbox_content.PerformLayout();
            this.pn_answerBorder.ResumeLayout(false);
            this.gbox_actions.ResumeLayout(false);
            this.gbox_modules.ResumeLayout(false);
            this.gbox_quizzes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbox_content;
        private GroupBox gbox_modules;
        private Button btn_delModule;
        private Button btn_addModule;
        private ListBox lbox_modules;
        private GroupBox gbox_quizzes;
        private Button btn_delQuiz;
        private Button btn_addQuiz;
        private ListBox lbox_quizzes;
        private Label lbl_question;
        private RichTextBox rtb_question;
        private Label lbl_answer;
        private RichTextBox rtb_answer;
        private Button btn_reveal;
        private GroupBox gbox_actions;
        private Button btn_2ez;
        private Button btn_ez;
        private Button btn_excuseMe;
        private Button btn_idk;
        private Button btn_meh;
        private Button btn_stats;
        private Panel pn_answerBorder;
    }
}