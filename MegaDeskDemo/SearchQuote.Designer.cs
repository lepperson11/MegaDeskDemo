namespace MegaDeskDemo
{
    partial class SearchQuote
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
            MainMenuBtn = new Button();
            SuspendLayout();
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.Location = new Point(12, 378);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(198, 52);
            MainMenuBtn.TabIndex = 22;
            MainMenuBtn.Text = "Back";
            MainMenuBtn.UseVisualStyleBackColor = true;
            MainMenuBtn.Click += MainMenuBtn_Click;
            // 
            // SearchQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 442);
            Controls.Add(MainMenuBtn);
            Name = "SearchQuote";
            Text = "SearchQuote";
            ResumeLayout(false);
        }

        #endregion

        private Button MainMenuBtn;
    }
}