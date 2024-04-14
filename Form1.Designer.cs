namespace Capital_Quiz
{
    partial class Form1
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
            userAnswertb = new TextBox();
            nextQuestionbtn = new Button();
            label1 = new Label();
            scorelbl = new Label();
            QuestionsrichTextBox = new RichTextBox();
            startbtn = new Button();
            label2 = new Label();
            questionCountlbl = new Label();
            SuspendLayout();
            // 
            // userAnswertb
            // 
            userAnswertb.Location = new Point(134, 253);
            userAnswertb.Name = "userAnswertb";
            userAnswertb.Size = new Size(480, 27);
            userAnswertb.TabIndex = 1;
            // 
            // nextQuestionbtn
            // 
            nextQuestionbtn.BackColor = Color.Red;
            nextQuestionbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextQuestionbtn.ForeColor = Color.Gold;
            nextQuestionbtn.Location = new Point(278, 324);
            nextQuestionbtn.Name = "nextQuestionbtn";
            nextQuestionbtn.Size = new Size(220, 56);
            nextQuestionbtn.TabIndex = 2;
            nextQuestionbtn.Text = "Next";
            nextQuestionbtn.UseVisualStyleBackColor = false;
            nextQuestionbtn.Click += nextQuestionbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "Score";
            // 
            // scorelbl
            // 
            scorelbl.BorderStyle = BorderStyle.FixedSingle;
            scorelbl.Location = new Point(12, 47);
            scorelbl.Name = "scorelbl";
            scorelbl.Size = new Size(150, 39);
            scorelbl.TabIndex = 4;
            // 
            // QuestionsrichTextBox
            // 
            QuestionsrichTextBox.Location = new Point(26, 112);
            QuestionsrichTextBox.Name = "QuestionsrichTextBox";
            QuestionsrichTextBox.Size = new Size(762, 110);
            QuestionsrichTextBox.TabIndex = 5;
            QuestionsrichTextBox.Text = "";
            // 
            // startbtn
            // 
            startbtn.BackColor = Color.Red;
            startbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startbtn.ForeColor = Color.FromArgb(192, 192, 0);
            startbtn.Location = new Point(278, 404);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(220, 60);
            startbtn.TabIndex = 6;
            startbtn.Text = "Start";
            startbtn.UseVisualStyleBackColor = false;
            startbtn.Click += startbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(610, 14);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 7;
            label2.Text = "Number of Questions";
            // 
            // questionCountlbl
            // 
            questionCountlbl.BorderStyle = BorderStyle.FixedSingle;
            questionCountlbl.Location = new Point(610, 47);
            questionCountlbl.Name = "questionCountlbl";
            questionCountlbl.Size = new Size(150, 39);
            questionCountlbl.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(questionCountlbl);
            Controls.Add(label2);
            Controls.Add(startbtn);
            Controls.Add(QuestionsrichTextBox);
            Controls.Add(scorelbl);
            Controls.Add(label1);
            Controls.Add(nextQuestionbtn);
            Controls.Add(userAnswertb);
            Name = "Form1";
            Text = "Capital Quiz";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userAnswertb;
        private Button nextQuestionbtn;
        private Label label1;
        private Label scorelbl;
        private RichTextBox QuestionsrichTextBox;
        private Button startbtn;
        private Label label2;
        private Label questionCountlbl;
    }
}
