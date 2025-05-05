namespace MegaDeskDemo
{
    partial class AddQuote
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
            components = new System.ComponentModel.Container();
            MainMenuBtn = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            WidthReq = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            DateLabel = new Label();
            NameBox = new TextBox();
            WidthBox = new TextBox();
            DepthBox = new TextBox();
            DrawerInput = new ComboBox();
            MaterialComboBox = new ComboBox();
            ShippingComboBox = new ComboBox();
            WidthErrorProvider = new ErrorProvider(components);
            NameErrorProvider = new ErrorProvider(components);
            DepthErrorProvider = new ErrorProvider(components);
            DrawerErrorProvider = new ErrorProvider(components);
            ShippingErrorProvider = new ErrorProvider(components);
            MaterialErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)WidthErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepthErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DrawerErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShippingErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaterialErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.Location = new Point(12, 378);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(198, 52);
            MainMenuBtn.TabIndex = 0;
            MainMenuBtn.Text = "Back";
            MainMenuBtn.UseVisualStyleBackColor = true;
            MainMenuBtn.Click += GoBack;
            // 
            // button2
            // 
            button2.Location = new Point(235, 378);
            button2.Name = "button2";
            button2.Size = new Size(198, 52);
            button2.TabIndex = 1;
            button2.Text = "Submit Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SubmitOrderBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 2;
            label1.Text = "MegaDesk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 3;
            label2.Text = "Today's Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(158, 19);
            label3.TabIndex = 4;
            label3.Text = "Please Enter Your Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 5;
            label4.Text = "Desk Width:";
            // 
            // WidthReq
            // 
            WidthReq.AutoSize = true;
            WidthReq.Font = new Font("Segoe UI", 7F);
            WidthReq.Location = new Point(12, 166);
            WidthReq.Name = "WidthReq";
            WidthReq.Size = new Size(152, 12);
            WidthReq.TabIndex = 6;
            WidthReq.Text = "min 24 inches and max 96 inches";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(12, 193);
            label6.Name = "label6";
            label6.Size = new Size(84, 19);
            label6.TabIndex = 7;
            label6.Text = "Desk Depth:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F);
            label7.Location = new Point(12, 212);
            label7.Name = "label7";
            label7.Size = new Size(152, 12);
            label7.TabIndex = 8;
            label7.Text = "min 12 inches and max 48 inches";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(12, 238);
            label8.Name = "label8";
            label8.Size = new Size(144, 19);
            label8.TabIndex = 9;
            label8.Text = "Desk Drawer Amount:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(12, 280);
            label9.Name = "label9";
            label9.Size = new Size(94, 19);
            label9.TabIndex = 10;
            label9.Text = "Material Type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(12, 324);
            label10.Name = "label10";
            label10.Size = new Size(133, 19);
            label10.TabIndex = 11;
            label10.Text = "Shipping Timeframe:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7F);
            label11.Location = new Point(12, 343);
            label11.Name = "label11";
            label11.Size = new Size(152, 12);
            label11.TabIndex = 12;
            label11.Text = "Express 3 days to standard 7 days";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10F);
            DateLabel.Location = new Point(346, 64);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(87, 19);
            DateLabel.TabIndex = 13;
            DateLabel.Text = "Today's Date";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(299, 104);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(134, 23);
            NameBox.TabIndex = 14;
            NameBox.Validating += NameBox_Validating;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(299, 147);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(134, 23);
            WidthBox.TabIndex = 15;
            WidthBox.Validating += WidthBox_Validating;
            // 
            // DepthBox
            // 
            DepthBox.Location = new Point(299, 193);
            DepthBox.Name = "DepthBox";
            DepthBox.Size = new Size(134, 23);
            DepthBox.TabIndex = 16;
            DepthBox.Validating += DepthBox_Validating;
            // 
            // DrawerInput
            // 
            DrawerInput.FormattingEnabled = true;
            DrawerInput.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            DrawerInput.Location = new Point(299, 238);
            DrawerInput.Name = "DrawerInput";
            DrawerInput.Size = new Size(134, 23);
            DrawerInput.TabIndex = 17;
            DrawerInput.Validating += DrawerBox_Validating;
            // 
            // MaterialComboBox
            // 
            MaterialComboBox.FormattingEnabled = true;
            MaterialComboBox.Items.AddRange(new object[] { "wood", "metal", "plastic" });
            MaterialComboBox.Location = new Point(299, 280);
            MaterialComboBox.Name = "MaterialComboBox";
            MaterialComboBox.Size = new Size(134, 23);
            MaterialComboBox.TabIndex = 18;
            MaterialComboBox.Validating += MaterialBox_Validating;
            // 
            // ShippingComboBox
            // 
            ShippingComboBox.FormattingEnabled = true;
            ShippingComboBox.Items.AddRange(new object[] { "3", "5", "7" });
            ShippingComboBox.Location = new Point(299, 324);
            ShippingComboBox.Name = "ShippingComboBox";
            ShippingComboBox.Size = new Size(134, 23);
            ShippingComboBox.TabIndex = 19;
            ShippingComboBox.Validating += ShippingBox_Validating;
            // 
            // WidthErrorProvider
            // 
            WidthErrorProvider.ContainerControl = this;
            // 
            // NameErrorProvider
            // 
            NameErrorProvider.ContainerControl = this;
            // 
            // DepthErrorProvider
            // 
            DepthErrorProvider.ContainerControl = this;
            // 
            // DrawerErrorProvider
            // 
            DrawerErrorProvider.ContainerControl = this;
            // 
            // ShippingErrorProvider
            // 
            ShippingErrorProvider.ContainerControl = this;
            // 
            // MaterialErrorProvider
            // 
            MaterialErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 442);
            Controls.Add(ShippingComboBox);
            Controls.Add(MaterialComboBox);
            Controls.Add(DrawerInput);
            Controls.Add(DepthBox);
            Controls.Add(WidthBox);
            Controls.Add(NameBox);
            Controls.Add(DateLabel);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(WidthReq);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(MainMenuBtn);
            Name = "AddQuote";
            Text = "AddQuote";
            Load += AddQuote_Load;
            ((System.ComponentModel.ISupportInitialize)WidthErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)NameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepthErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DrawerErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShippingErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaterialErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainMenuBtn;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label WidthReq;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label DateLabel;
        private TextBox NameBox;
        private TextBox WidthBox;
        private TextBox DepthBox;
        private ComboBox DrawerInput;
        private ComboBox MaterialComboBox;
        private ComboBox ShippingComboBox;
        private ErrorProvider WidthErrorProvider;
        private ErrorProvider NameErrorProvider;
        private ErrorProvider DepthErrorProvider;
        private ErrorProvider DrawerErrorProvider;
        private ErrorProvider ShippingErrorProvider;
        private ErrorProvider MaterialErrorProvider;
    }
}