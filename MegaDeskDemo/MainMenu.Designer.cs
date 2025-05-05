namespace MegaDeskDemo
{
    partial class MainMenu
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
            newQoute = new Button();
            viewQuotes = new Button();
            searchQuotes = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // newQoute
            // 
            newQoute.Location = new Point(12, 12);
            newQoute.Name = "newQoute";
            newQoute.Size = new Size(198, 52);
            newQoute.TabIndex = 0;
            newQoute.Text = "Add New Quote";
            newQoute.UseVisualStyleBackColor = true;
            newQoute.Click += OpenAddQuote;
            // 
            // viewQuotes
            // 
            viewQuotes.Location = new Point(12, 70);
            viewQuotes.Name = "viewQuotes";
            viewQuotes.Size = new Size(198, 52);
            viewQuotes.TabIndex = 1;
            viewQuotes.Text = "View Quotes";
            viewQuotes.UseVisualStyleBackColor = true;
            viewQuotes.Click += ViewQuotes_Btn;
            // 
            // searchQuotes
            // 
            searchQuotes.Location = new Point(12, 128);
            searchQuotes.Name = "searchQuotes";
            searchQuotes.Size = new Size(198, 52);
            searchQuotes.TabIndex = 2;
            searchQuotes.Text = "Search Qoutes";
            searchQuotes.UseVisualStyleBackColor = true;
            searchQuotes.Click += SearchQuotes_Btn;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(12, 186);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(198, 52);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP__1_;
            pictureBox1.Location = new Point(216, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 247);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(searchQuotes);
            Controls.Add(viewQuotes);
            Controls.Add(newQoute);
            Name = "MainMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button newQoute;
        private Button viewQuotes;
        private Button searchQuotes;
        private Button exitButton;
        private PictureBox pictureBox1;
    }
}
