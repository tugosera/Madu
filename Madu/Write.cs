using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Madu
{
    public class Write
    {
        public string pathScore = @"..\..\..\Scores.txt";
        public string pathTotal = @"..\..\..\Total.txt";
        public void write(Login login,Snake snake, Stopwatch sw)
        {

            using (StreamWriter s = new StreamWriter(pathScore, true))
            {
                s.WriteLine(snake.gool);
            }

            using (StreamWriter s = new StreamWriter(pathTotal, true))
            {
                s.WriteLine(login.Name + " Score = " + snake.gool + " Time is " + sw);
            }
        }
    }
}
