using System;
using Xunit;

namespace Lab04_TicTacToe.Classes
{
    public class UnitTest1
    {
        
        [Fact]
        public void ReturnsWinnerTest()
        {
            // Arrange
            Player player1 = new Player();
            Player player2 = new Player();

            Game game = new Game(player1, player2);



            // Act
            bool winnerExists = game.CheckForWinner(game.Board);

            // Assert
            Assert.True(winnerExists);
            
        }
    }
}
