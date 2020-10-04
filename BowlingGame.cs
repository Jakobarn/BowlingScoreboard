using System;
using System.Collections.Generic;

namespace BowlingScoreboard
{
    public class BowlingGame
    {
        private int[] m_rools           = new int[m_maxRools];
        private int m_roolIndex         = 0;
        private const int m_totalFrames = 10;
        private const int m_maxRools    = 21; // Max achieved if the player hits a spare in 10th frame.
        
        private bool isStrike( int frameIndex )
        {
            return (m_rools[frameIndex] == 10); 
        }

        private bool isSpare(int frameIndex) {
            return (m_rools[frameIndex] + m_rools[frameIndex + 1] == 10);
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;

            for (int frame = 0; frame < m_totalFrames; frame++)
            {
                if (isStrike(frameIndex))
                {
                    score += 10 + m_rools[frameIndex + 1] + m_rools[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (isSpare(frameIndex))
                {
                    score += 10 + m_rools[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += m_rools[frameIndex] + m_rools[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }

        public BowlingGame Roll(int knockedDownPins)
        {
            m_rools[m_roolIndex++] = knockedDownPins;  
            return this;
        }
    }
}