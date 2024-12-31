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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
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
            // button1
            // 
            button1.Location = new Point(103, 560);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(244, 560);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(393, 560);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 344);
            label3.Name = "label3";
            label3.Size = new Size(28, 25);
            label3.TabIndex = 6;
            label3.Text = "A:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 390);
            label4.Name = "label4";
            label4.Size = new Size(26, 25);
            label4.TabIndex = 7;
            label4.Text = "B:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 431);
            label5.Name = "label5";
            label5.Size = new Size(27, 25);
            label5.TabIndex = 8;
            label5.Text = "C:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 201);
            label6.Name = "label6";
            label6.Size = new Size(299, 25);
            label6.TabIndex = 9;
            label6.Text = "あなたの選択によって物語は変化します。";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(123, 236);
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
            listBox1.Size = new Size(537, 529);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 693);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
    }
}
