namespace ST10361554_PROG6221_ICE_Task_4
{
    public partial class CalculatorForm : Form
    {
        // Default constructor for the CalculatorForm class
        public CalculatorForm()
        {
            // Initialize the components of the form
            InitializeComponent();
        }

        // Event handler for the calculateButton click event
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields before performing any calculations
                if (ValidateInput())
                {
                    // Instantiate a new Calculator object
                    Calculator calc = new Calculator();

                    // Get the first number from the firstNumberTextbox and convert it to a double
                    string firstNumber = firstNumberTextbox.Text;
                    double num1 = Convert.ToDouble(firstNumber);
                    calc.Num1 = num1;

                    // Get the second number from the secondNumberTextbox and convert it to a double
                    string secondNumber = secondNumberTextbox.Text;
                    double num2 = Convert.ToDouble(secondNumber);
                    calc.Num2 = num2;

                    // Get the selected operation from the operationComboBox
                    string operation = operationComboBox.Text;

                    // Perform the selected operation using the Calculator object
                    if (operation.Equals("Addition"))
                    {
                        // Subscribe to the CalculationPerformed event and display a success message with the result
                        calc.CalculationPerformed += (operation) => MessageBox.Show($"Operation performed: {operation} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        calc.Add(num1, num2);
                    }
                    else if (operation.Equals("Subtraction"))
                    {
                        // Subscribe to the CalculationPerformed event and display a success message with the result
                        calc.CalculationPerformed += (operation) => MessageBox.Show($"Operation performed: {operation} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        calc.Subtract(num1, num2);
                    }
                    else if (operation.Equals("Multiplication"))
                    {
                        // Subscribe to the CalculationPerformed event and display a success message with the result
                        calc.CalculationPerformed += (operation) => MessageBox.Show($"Operation performed: {operation} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        calc.Multiply(num1, num2);
                    }
                    else if (operation.Equals("Division"))
                    {
                        // Subscribe to the CalculationPerformed event and display a success message with the result
                        calc.CalculationPerformed += (operation) => MessageBox.Show($"Operation performed: {operation} \n Result: {calc.Result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        calc.Divide(num1, num2);
                    }
                }
                else
                {
                    // Throw an exception if the input is not valid
                    throw new Exception(message: "Check input values before continuing");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception is thrown
                MessageBox.Show($"An Error has occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clear the input fields and reset the operationComboBox after the calculation is performed
                firstNumberTextbox.Clear();
                secondNumberTextbox.Clear();
                operationComboBox.SelectedIndex = -1;
            }
        }

        // This method, ValidateInput, checks if the input fields in the user interface are valid
        public bool ValidateInput()
        {
            // Initialize a boolean variable, isValid, to true
            bool isValid = true;

            // Check if the text box for the first number is null or empty
            if (firstNumberTextbox.Text == null || firstNumberTextbox.Text.Equals(""))
            {
                // If it is, set isValid to false
                isValid = false;
            }

            // Check if the text box for the second number is null or empty
            if (secondNumberTextbox.Text == null || secondNumberTextbox.Text.Equals(""))
            {
                // If it is, set isValid to false
                isValid = false;
            }

            // Check if the selected index of the combo box for the operation is -1
            // (which means no operation is selected)
            if (operationComboBox.SelectedIndex == -1)
            {
                // If it is, set isValid to false
                isValid = false;
            }

            // Return the value of isValid
            return isValid;
        }
    }
}
