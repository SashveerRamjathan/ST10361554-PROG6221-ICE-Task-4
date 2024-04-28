using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task_4
{
    public class Calculator
    {
        // A property for the first number in a calculation
        public double Num1 { get; set; }

        // A property for the second number in a calculation
        public double Num2 { get; set; }

        // A property for the result of a calculation
        public double Result { get; set; }

        // A delegate that represents an event raised when a calculation is performed
        public delegate void CalculationPerformedEventHandler(string operationPerformed);

        // An event that is raised when a calculation is performed
        public event CalculationPerformedEventHandler? CalculationPerformed;

        // A method that performs addition on two numbers and raises the CalculationPerformed event
        public void Add(double num1, double num2)
        {
            this.Result = num1 + num2;
            OnCalculationPerformed("Addition");
        }

        // A method that performs subtraction on two numbers and raises the CalculationPerformed event
        public void Subtract(double num1, double num2)
        {
            this.Result = num1 - num2;
            OnCalculationPerformed("Subtraction");
        }

        // A method that performs multiplication on two numbers and raises the CalculationPerformed event
        public void Multiply(double num1, double num2)
        {
            this.Result = num1 * num2;
            OnCalculationPerformed("Multiplication");
        }

        // A method that performs division on two numbers and raises the CalculationPerformed event
        public void Divide(double num1, double num2)
        {
            if (num2!= 0)
            {
                this.Result = num1 / num2;
                OnCalculationPerformed("Division");
            }
            else throw new Exception(message: "Can't Divide by 0");
        }

        // A method that raises the CalculationPerformed event
        public virtual void OnCalculationPerformed(string operationPerformed)
        {
            if (CalculationPerformed!= null)
            {
                CalculationPerformed(operationPerformed);
            }
        }
    }
}
