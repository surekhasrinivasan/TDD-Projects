using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPasswordService;

namespace CheckPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Password.CheckPassword("$Alphes"));

            Console.WriteLine(Password.CheckPassword("@John123"));

            Console.WriteLine(Password.CheckPassword("Sami&123"));

            Console.WriteLine(Password.CheckPassword("Aum Chant"));

            Console.WriteLine(Password.CheckPassword("abracaDabrabra"));

            bool result = Password.CheckPassword("Smith");
            Console.WriteLine(result);
        }
    }
}
