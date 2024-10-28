using Madu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Madu
{
    public class FindBest
    {
        public int maxIndex = 0;
        public void findBest(Write write)
        {
            int maxNumber = 0;

            string[] score = File.ReadAllLines(write.pathScore);
            int[] intArray = new int[score.Length];

            for (int y = 0; y < score.Length; y++)
            {
                intArray[y] = int.Parse(score[y]);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > maxNumber)
                {
                    maxNumber = intArray[i];
                    maxIndex = i;
                }
            }
        } 
    }
}




