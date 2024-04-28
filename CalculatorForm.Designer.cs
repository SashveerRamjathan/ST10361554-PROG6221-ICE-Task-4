namespace ST10361554_PROG6221_ICE_Task_4
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            welcomeLabel = new Label();
            firstNumberLabel = new Label();
            firstNumberTextbox = new TextBox();
            secondNumberLabel = new Label();
            secondNumberTextbox = new TextBox();
            operationLabel = new Label();
            operationComboBox = new ComboBox();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(12, 9);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(193, 17);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to my calculator app";
            // 
            // firstNumberLabel
            // 
            firstNumberLabel.AutoSize = true;
            firstNumberLabel.Location = new Point(12, 44);
            firstNumberLabel.Name = "firstNumberLabel";
            firstNumberLabel.Size = new Size(125, 15);
            firstNumberLabel.TabIndex = 1;
            firstNumberLabel.Text = "Enter the first number:";
            // 
            // firstNumberTextbox
            // 
            firstNumberTextbox.Location = new Point(12, 62);
            firstNumberTextbox.Name = "firstNumberTextbox";
            firstNumberTextbox.Size = new Size(290, 23);
            firstNumberTextbox.TabIndex = 2;
            // 
            // secondNumberLabel
            // 
            secondNumberLabel.AutoSize = true;
            secondNumberLabel.Location = new Point(12, 102);
            secondNumberLabel.Name = "secondNumberLabel";
            secondNumberLabel.Size = new Size(143, 15);
            secondNumberLabel.TabIndex = 3;
            secondNumberLabel.Text = "Enter the second number:";
            // 
            // secondNumberTextbox
            // 
            secondNumberTextbox.Location = new Point(12, 120);
            secondNumberTextbox.Name = "secondNumberTextbox";
            secondNumberTextbox.Size = new Size(290, 23);
            secondNumberTextbox.TabIndex = 4;
            // 
            // operationLabel
            // 
            operationLabel.AutoSize = true;
            operationLabel.Location = new Point(12, 165);
            operationLabel.Name = "operationLabel";
            operationLabel.Size = new Size(264, 15);
            operationLabel.TabIndex = 5;
            operationLabel.Text = "Choose the operation you would like to perform:";
            // 
            // operationComboBox
            // 
            operationComboBox.FormattingEnabled = true;
            operationComboBox.Items.AddRange(new object[] { "Addition", "Subtraction", "Multiplication", "Division" });
            operationComboBox.Location = new Point(12, 183);
            operationComboBox.Name = "operationComboBox";
            operationComboBox.Size = new Size(290, 23);
            operationComboBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.Lime;
            calculateButton.Location = new Point(208, 251);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 34);
            calculateButton.TabIndex = 7;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 297);
            Controls.Add(calculateButton);
            Controls.Add(operationComboBox);
            Controls.Add(operationLabel);
            Controls.Add(secondNumberTextbox);
            Controls.Add(secondNumberLabel);
            Controls.Add(firstNumberTextbox);
            Controls.Add(firstNumberLabel);
            Controls.Add(welcomeLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label firstNumberLabel;
        private TextBox firstNumberTextbox;
        private Label secondNumberLabel;
        private TextBox secondNumberTextbox;
        private Label operationLabel;
        private ComboBox operationComboBox;
        private Button calculateButton;
    }
}
