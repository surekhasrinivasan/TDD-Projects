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
            int sum = 0;
            char[] delimiters = new char[] { '/', ',', '\n', ';', '*', '[', ']' };

            string[] strNum = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < strNum.Length; i++)
            {
                int num = int.Parse(strNum[i]);
                                
                if(num < 0)
                {
                    throw new ArgumentException("Negatives not allowed and the negative that was passed:" + strNum[i]);              
                }
                if (numbers == "")
                {
                    return 0;
                }
                if (numbers.Length == 1)
                {
                    int number = int.Parse(numbers);
                    return number;
                }                  
                else
                {                    
                    sum = sum + (num >= 1000 ? 0 : num);
                }                
            }            
            return sum;          
        }
    }
}