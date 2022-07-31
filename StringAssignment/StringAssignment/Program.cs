using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string Uno = " Ciao, ";
            string Dos = "how are you? ";
            string Tres = "My name is Pablo ";

            Dos = Dos.ToUpper();
            Console.WriteLine(Uno + Dos + Tres);
            Console.ReadLine();


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Pablo");
            sb.Append("\nit is very nice to meet you!");
            sb.Append("\nPlease don't be shy.");
            sb.Append("\nTell me more about yourself?");
            sb.Append("\nWell thank you for your time!");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
