namespace MegaDeskDemo
{
    partial class ViewQuotes
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
            label1 = new Label();
            MainMenuBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 2);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 22;
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.Location = new Point(18, 388);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(198, 52);
            MainMenuBtn.TabIndex = 21;
            MainMenuBtn.Text = "Back";
            MainMenuBtn.UseVisualStyleBackColor = true;
            MainMenuBtn.Click += MainMenuBtn_Click;
            // 
            // ViewQuotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 442);
            Controls.Add(label1);
            Controls.Add(MainMenuBtn);
            Name = "ViewQuotes";
            Text = "ViewQuotes";
            Load += ViewQuotes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button MainMenuBtn;
    }
}