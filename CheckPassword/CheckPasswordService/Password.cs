using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPasswordService
{
    public static class Password
    {
        public static bool CheckPassword(string input)
        {
            // Min 6 chars and Max 12 chars
            if (input.Length < 6 || input.Length > 12)
            {
                return false;
            }

            // Password have no white space
            if (input.Contains(" "))
            {
                return false;
            }

            // should have 1 upper case char
            if (!input.Any(char.IsUpper))
            {
                return false;
            }

            // should have 1 lower case char
            if (!input.Any(char.IsLower))
            {
                return false;
            }
            
            // should not have 2 similar consecutive characters
            for(int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    return false;
                }                
            }

            // one special character
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToArray();

            foreach (char sc in specialCharacters)
            {
                if (input.Contains(sc))
                {
                    return true;                   
                }            
            }
            return false;
        }        
    }
}
