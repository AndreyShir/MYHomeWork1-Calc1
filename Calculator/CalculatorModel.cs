using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {
            
        }

        public object Calculate(int operand1, int operand2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return sumCalc(operand1,operand2);
                    break;
                case '-':
                    return difCalc(operand1,operand2);
                    break;
                case '/':
                    return divCalc(operand1,operand2);
                    break;
                case '*':
                    return multCalc(operand1,operand2);
                    break;
                default:
                    return null;
                    break;
            
            }
        }

        
    
        private static int sumCalc(int operand1,int operand2)
        {   
                return operand1 = operand1 + operand2;
        }
        private static int difCalc(int operand1,int operand2)
        {   
                return operand1 = operand1 - operand2;
        }
        private static object divCalc(int operand1,int operand2)
        {   
                try
                { 
                    return operand1 = operand1 / operand2;
                }
                catch (DivideByZeroException) when (operand2 == 0)
                {
                    return null;
                }
        }   
        private static int multCalc(int operand1,int operand2)
        {   
                return operand1 = operand1 * operand2;
        }
    }
}
