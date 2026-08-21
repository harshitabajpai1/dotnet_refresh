using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class Calculator
    {
        public int AddMe(int num1, int num2)
        {
            return num1 + num2;
        }   

        public int SubMe(int num1, int num2) => num1 - num2;   
        //lambda expression syntax supported in C# 7.3

        public int ProdMe(int num1, int num2) => num1 * num2;

        public float DivMe(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return (float)num1 / num2;
        }
    }
}
