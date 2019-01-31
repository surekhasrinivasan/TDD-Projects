using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorService
{
    public static class Calculator
    {
        public static int Add(string numbers)
        {
            if (numbers == "")
                return 0;

            if (numbers.Length == 1)
            {
                int num = int.Parse(numbers);
                return num;
            }
            int sum = 0;
            string[] strNum = numbers.Split(',');
            
            for(int i = 0; i < strNum.Length; i++)
            {
                sum +=int.Parse(strNum[i]);
            }
            
            return sum;          
        }
    }
}