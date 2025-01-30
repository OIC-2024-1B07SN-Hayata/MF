namespace MF
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
            konnitiwaaa = new Label();
            label1 = new Label();
            label2 = new Label();
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            button4 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // konnitiwaaa
            // 
            konnitiwaaa.AutoSize = true;
            konnitiwaaa.Location = new Point(393, 124);
            konnitiwaaa.Name = "konnitiwaaa";
            konnitiwaaa.Size = new Size(98, 25);
            konnitiwaaa.TabIndex = 0;
            konnitiwaaa.Text = "konnnitiwa";
            konnitiwaaa.Click += konnitiwaaa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 83);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 1;
            label1.Text = "こんばんは";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 503);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 2;
            label2.Text = "選択してください";
            // 
            // buttonA
            // 
            buttonA.Location = new Point(103, 560);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(112, 34);
            buttonA.TabIndex = 3;
            buttonA.Text = "音楽";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(244, 560);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(112, 34);
            buttonB.TabIndex = 4;
            buttonB.Text = "アニメ";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(393, 560);
            buttonC.Name = "buttonC";
            buttonC.RightToLeft = RightToLeft.No;
            buttonC.Size = new Size(112, 34);
            buttonC.TabIndex = 5;
            buttonC.Text = "スポーツ";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(187, 344);
            labelA.Name = "labelA";
            labelA.Size = new Size(28, 25);
            labelA.TabIndex = 6;
            labelA.Text = "A:";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(187, 390);
            labelB.Name = "labelB";
            labelB.Size = new Size(26, 25);
            labelB.TabIndex = 7;
            labelB.Text = "B:";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(186, 431);
            labelC.Name = "labelC";
            labelC.Size = new Size(27, 25);
            labelC.TabIndex = 8;
            labelC.Text = "C:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 158);
            label6.Name = "label6";
            label6.Size = new Size(299, 25);
            label6.TabIndex = 9;
            label6.Text = "あなたの選択によって物語は変化します。";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 194);
            label7.Name = "label7";
            label7.Size = new Size(349, 25);
            label7.TabIndex = 10;
            label7.Text = "物語を読んであなたらしい物語を作ってください。";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(576, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(576, 529);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Location = new Point(499, 83);
            button4.Name = "button4";
            button4.Size = new Size(71, 34);
            button4.TabIndex = 12;
            button4.Text = "start";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 257);
            label8.Name = "label8";
            label8.Size = new Size(30, 25);
            label8.TabIndex = 13;
            label8.Text = "　";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 693);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(konnitiwaaa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label konnitiwaaa;
        private Label label1;
        private Label label2;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private Button button4;
        private Label label8;
    }
}
