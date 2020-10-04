using System;
using BowlingScoreboard;
using Xunit;

public class BowlingGameTest
{
    [Fact]
    public void GutterGameTest()
    {
        var game = new BowlingGame();

        for (int i = 0; i < 20; i++)
        {
            game.Roll(0);
        }

        Assert.Equal(0,game.Score());
    }

    [Fact]
    public void PerfectGameTest()
    {
        var game = new BowlingGame();

        for (int i = 0; i < 12; i++)
        {
            game.Roll(10);
        }

        Assert.Equal(300,game.Score());
    }

    [Fact]
    public void ExampleScoreTest()
    {
        var game = new BowlingGame();

        game.Roll(1).Roll(4);

        game.Roll(4).Roll(5);

        game.Roll(6).Roll(4);  // Spare

        game.Roll(5).Roll(5);  // Spare

        game.Roll(10);         // Strike

        game.Roll(0).Roll(1);

        game.Roll(7).Roll(3);  // Spare

        game.Roll(6).Roll(4);  // Spare

        game.Roll(10);         // Strike

        game.Roll(2).Roll(8);  // Spare

        game.Roll(6);          // Extra roll

        Assert.Equal(133,game.Score());
    }
}