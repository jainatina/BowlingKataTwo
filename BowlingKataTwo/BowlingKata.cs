using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKataTwo
{
    public class BowlingKata
    {



        private int[] rolls;

        private int count;

        public BowlingKata()
        {
            rolls = new int[21];
        }

        public void Roll(int pins)
        {

            rolls[count] = pins;
            count++;


        }

        public int GetScore()
        {
            int score = 0;
            int currentroll = 0;

            for (int i = 0; i < 10; i++)
            {

                if (rolls[currentroll] == 10)
                {
                    score = score + rolls[currentroll] + rolls[currentroll + 1] + rolls[currentroll + 2];
                    currentroll = currentroll + 1;
                }
                else if (rolls[currentroll] + rolls[currentroll + 1] == 10)
                {

                    score = score + rolls[currentroll] + rolls[currentroll + 1] + rolls[currentroll + 2];
                    currentroll = currentroll + 2;

                }
                else
                {
                    score = score + rolls[currentroll] + rolls[currentroll + 1];
                    currentroll = currentroll + 2;
                }
                
            }

            return score;
        }
    }
}
