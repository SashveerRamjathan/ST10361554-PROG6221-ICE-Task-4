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
                if (ValidateInput())
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
                        calc.CalculationPerformed += (operation) => MessageBox.Show($"Operation performed: {operation} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        calc.Add(num1, num2);
                    }
                    else if (operation.Equals("Subtraction"))
                    {
                        calc.CalculationPerformed += (operation) => MessageBox.Show($"Operation performed: {operation} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        calc.Subtract(num1, num2);
                    }
                    else if (operation.Equals("Multiplication"))
                    {
                        calc.CalculationPerformed += (operation) => MessageBox.Show($"Operation performed: {operation} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        calc.Multiply(num1, num2);
                    }
                    else if (operation.Equals("Division"))
                    {
                        calc.CalculationPerformed += (operation) => MessageBox.Show($"Operation performed: {operation} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        calc.Divide(num1, num2);
                    }
                }
                else throw new Exception(message: "Check input values before continuing");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error has occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                firstNumberTextbox.Clear();
                secondNumberTextbox.Clear();
                operationComboBox.SelectedIndex = -1;
            }
        }

        public bool ValidateInput()
        {
            bool isValid = true;

            if (firstNumberTextbox.Text == null || firstNumberTextbox.Text.Equals(""))
            {
                isValid = false;
            }

            if (secondNumberTextbox.Text == null || secondNumberTextbox.Text.Equals(""))
            {
                isValid = false;
            }

            if (operationComboBox.SelectedIndex == -1)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
