using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task_4
{
    public class Calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string? OperationPerformed { get; set; }
        public double Result { get; set; }

        public delegate void CalculationPerformedEventHandler(Calculator calc);

        public event CalculationPerformedEventHandler? CalculationPerformed;

        public void Add(double num1, double num2)
        {
            this.Result = num1 + num2;
            this.OperationPerformed = "Addition";
            OnCalculationPerformed(this);
        }

        public void Subtract(double num1, double num2)
        {
            this.Result = num1 - num2;
            this.OperationPerformed = "Subtraction";
            OnCalculationPerformed(this);
        }

        public void Multiply(double num1, double num2)
        {
            this.Result = num1 * num2;
            this.OperationPerformed = "Multiplication";
            OnCalculationPerformed(this);
        }

        public void Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                this.Result = num1 / num2;
                this.OperationPerformed = "Division";
                OnCalculationPerformed(this);
            }
            else throw new Exception(message: "Can't Divide by 0");
        }

        public virtual void OnCalculationPerformed(Calculator calc)
        {
            CalculationPerformed(calc);
        }
    }
}
