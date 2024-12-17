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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(konnitiwaaa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label konnitiwaaa;
    }
}
