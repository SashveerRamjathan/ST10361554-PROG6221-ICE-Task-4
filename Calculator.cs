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
        public double Result { get; set; }

        public delegate void CalculationPerformedEventHandler(string operationPerformed);

        public event CalculationPerformedEventHandler? CalculationPerformed;

        public void Add(double num1, double num2)
        {
            this.Result = num1 + num2;
            OnCalculationPerformed("Addition");
        }

        public void Subtract(double num1, double num2)
        {
            this.Result = num1 - num2;
            OnCalculationPerformed("Subtraction");
        }

        public void Multiply(double num1, double num2)
        {
            this.Result = num1 * num2;
            OnCalculationPerformed("Multiplication");
        }

        public void Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                this.Result = num1 / num2;
                OnCalculationPerformed("Division");
            }
            else throw new Exception(message: "Can't Divide by 0");
        }

        public virtual void OnCalculationPerformed(string operationPerformed)
        {
            if (CalculationPerformed != null)
            {
                CalculationPerformed(operationPerformed);
            }
        }
    }
}
