namespace Calc
{
    partial class AboutDialog
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
            userControl11 = new UserControl1();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(308, 67);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(188, 188);
            userControl11.TabIndex = 0;
            userControl11.Load += userControl11_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 269);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 295);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // AboutDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userControl11);
            Name = "AboutDialog";
            Text = "AboutDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControl1 userControl11;
        private Label label1;
        private Label label2;
    }
}