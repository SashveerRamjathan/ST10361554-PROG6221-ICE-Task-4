namespace ST10361554_PROG6221_ICE_Task_4
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Calculator calc = new Calculator();

                string firstNumber = firstNumberTextbox.Text;
                double num1 = Convert.ToDouble(firstNumber);
                calc.Num1 = num1;

                string secondNumber = secondNumberTextbox.Text;
                double num2 = Convert.ToDouble(secondNumber);
                calc.Num2 = num2;

                string operation = operationComboBox.Text;

                if (operation.Equals("Addition"))
                {
                    calc.OperationPerformed = "Addition";
                    calc.Add(num1, num2);
                    calc.CalculationPerformed += (calc) => MessageBox.Show($"Operation performed: {calc.OperationPerformed} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (operation.Equals("Subtraction"))
                {
                    calc.OperationPerformed = "Addition";
                    calc.Subtract(num1, num2);
                    calc.CalculationPerformed += (calc) => MessageBox.Show($"Operation performed: {calc.OperationPerformed} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (operation.Equals("Multiplication"))
                {
                    calc.OperationPerformed = "Addition";
                    calc.Multiply(num1, num2);
                    calc.CalculationPerformed += (calc) => MessageBox.Show($"Operation performed: {calc.OperationPerformed} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (operation.Equals("Division"))
                {
                    calc.OperationPerformed = "Addition";
                    calc.Divide(num1, num2);
                    calc.CalculationPerformed += (calc) => MessageBox.Show($"Operation performed: {calc.OperationPerformed} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                firstNumberTextbox.Clear();
                secondNumberTextbox.Clear();
                operationComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error has occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNumberTextbox.Clear();
                secondNumberTextbox.Clear();
                operationComboBox.SelectedIndex = -1;
            }
        }
    }
}
