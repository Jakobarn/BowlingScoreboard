# Challenge: Score a bowling game
By Jakob A. Sørensen

## Implementation

In the following section I will discuss some of the design choices and limitations of my bowling scoreboard implementation.

### BowlingGame
The biggest challenge for me in this task was to figure out how the point scoring from the bowling rules could be mapped to as simple an implementation as possible. When it dawned on me that it in some cases was necessary to know the result from future frames, my implementation was relatively simple to write. I chose to encapsulate the bowling gamescore logic in the **BowlingGame** class.
Do note:
- The score can only be calculated when a game is fully completed. Thus, the **Score** method is only valid when all frames have been completed.
- Argument input to the **roll** method is not validated.

### ConsoleDisplay
A very simple UI has been implemented using the Console. The current **DisplayConsole** implement the small **IDisplay** interface, which in the future could be implemented by an awesome graphic display.

### BowlingScoreboard 
The **BowlingScoreboard** encapsulates the bowling scoreboard logic.  Currently, this is very simple with a minimal implementation. In the future, it would be relevant to enable more players to play bowling in parallel, and that players actually have the opportunity to provide real input to the scoreboard.

