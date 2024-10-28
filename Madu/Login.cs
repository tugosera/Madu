using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Madu
{
    public class Login
    {

        public string Name = ""; 

        public void login()
        {

            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Select your name");

            Console.SetCursorPosition(30, 12);
            Name = Console.ReadLine();
            
        }
    }
}