namespace BowlingScoreboard
{
    public class BowlingScoreboard
    {
        private BowlingGame m_bowlingGame = new BowlingGame();
        private IDisplay m_gameDisplay    = new ConsoleDisplay();

        public void RunGame()
        {
            m_gameDisplay.showWelcomeMessage();

            // Example score
            m_bowlingGame.Roll(1).Roll(4);
            m_bowlingGame.Roll(4).Roll(5);
            m_bowlingGame.Roll(6).Roll(4); // Spare
            m_bowlingGame.Roll(5).Roll(5); // Spare
            m_bowlingGame.Roll(10);        // Strike  
            m_bowlingGame.Roll(0).Roll(1);
            m_bowlingGame.Roll(7).Roll(3);
            m_bowlingGame.Roll(6).Roll(4); // Spare
            m_bowlingGame.Roll(10);        // Strike
            m_bowlingGame.Roll(2).Roll(8); // Spare
            m_bowlingGame.Roll(6);         // Extra roll

            int gameScore = m_bowlingGame.Score();
            m_gameDisplay.showScore(gameScore);
        }
    }
}