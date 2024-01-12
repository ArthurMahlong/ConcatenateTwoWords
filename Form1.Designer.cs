namespace ConcatenateTwoWords
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
            label1 = new Label();
            textBox1 = new TextBox();
            btnAddWord = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnConcat = new Button();
            rbRemove1 = new RadioButton();
            rbRemove2 = new RadioButton();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter a new word:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 25);
            textBox1.TabIndex = 1;
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(251, 92);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(75, 26);
            btnAddWord.TabIndex = 2;
            btnAddWord.Text = "Add word";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 228);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 3;
            label2.Text = "Select a word:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 182);
            label3.Name = "label3";
            label3.Size = new Size(28, 19);
            label3.TabIndex = 4;
            label3.Text = "OR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 228);
            label4.Name = "label4";
            label4.Size = new Size(134, 19);
            label4.TabIndex = 5;
            label4.Text = "Select another word:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(75, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 25);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(372, 262);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(220, 25);
            comboBox2.TabIndex = 7;
            // 
            // btnConcat
            // 
            btnConcat.Location = new Point(251, 346);
            btnConcat.Name = "btnConcat";
            btnConcat.Size = new Size(101, 26);
            btnConcat.TabIndex = 8;
            btnConcat.Text = "Concatenate";
            btnConcat.UseVisualStyleBackColor = true;
            btnConcat.Click += btnConcat_Click;
            // 
            // rbRemove1
            // 
            rbRemove1.AutoSize = true;
            rbRemove1.Location = new Point(75, 295);
            rbRemove1.Name = "rbRemove1";
            rbRemove1.Size = new Size(76, 23);
            rbRemove1.TabIndex = 9;
            rbRemove1.TabStop = true;
            rbRemove1.Text = "Remove";
            rbRemove1.UseVisualStyleBackColor = true;
            rbRemove1.CheckedChanged += rbRemove1_CheckedChanged;
            // 
            // rbRemove2
            // 
            rbRemove2.AutoSize = true;
            rbRemove2.Location = new Point(372, 295);
            rbRemove2.Name = "rbRemove2";
            rbRemove2.Size = new Size(76, 23);
            rbRemove2.TabIndex = 10;
            rbRemove2.TabStop = true;
            rbRemove2.Text = "Remove";
            rbRemove2.UseVisualStyleBackColor = true;
            rbRemove2.CheckedChanged += rbRemove2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(251, 396);
            label5.Name = "label5";
            label5.Size = new Size(155, 21);
            label5.TabIndex = 11;
            label5.Text = "                                    ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(label5);
            Controls.Add(rbRemove2);
            Controls.Add(rbRemove1);
            Controls.Add(btnConcat);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddWord);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "                           ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnAddWord;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnConcat;
        private RadioButton rbRemove1;
        private RadioButton rbRemove2;
        private Label label5;
    }
}
