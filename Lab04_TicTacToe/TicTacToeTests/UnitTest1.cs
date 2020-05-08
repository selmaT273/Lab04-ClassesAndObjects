using System;
using Xunit;

namespace Lab04_TicTacToe.Classes
{
    public class TicTacToeTests
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


        [Fact]
        public void Can_switch_player()
        {
            // Arrange
            Player player1 = new Player();
            Player player2 = new Player();

            Game game = new Game(player1, player2);
            



            // Act
            Player canSwitch = game.NextPlayer();

            // Assert
            Assert.Equal(player1, canSwitch);

        }
    }
}
