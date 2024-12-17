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
            SuspendLayout();
            // 
            // konnitiwaaa
            // 
            konnitiwaaa.AutoSize = true;
            konnitiwaaa.Location = new Point(402, 217);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
