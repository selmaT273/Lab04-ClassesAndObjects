using System;
using Xunit;
using Xunit.Sdk;

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
            Player player1 = new Player() { Name = "Ted" };
            Player player2 = new Player() { Name = "Bill" };

            Game game = new Game(player1, player2);


            // Act
            // Round 1
            Player canSwitch1 = game.NextPlayer();
            game.SwitchPlayer();
            Player canSwitchAgain1 = game.NextPlayer();
            game.SwitchPlayer();
            // Round 2
            Player canSwitch2 = game.NextPlayer();
            game.SwitchPlayer();
            Player canSwitchAgain2 = game.NextPlayer();
            game.SwitchPlayer();
            // Round 3
            Player canSwitch3 = game.NextPlayer();
            game.SwitchPlayer();
            Player canSwitchAgain3 = game.NextPlayer();
            game.SwitchPlayer();

            // Assert
            Assert.Equal(player2, canSwitch1);
            Assert.Equal(player1, canSwitchAgain1);
            Assert.Equal(player2, canSwitch2);
            Assert.Equal(player1, canSwitchAgain2);
            Assert.Equal(player2, canSwitch3);
            Assert.Equal(player1, canSwitchAgain3);

        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(2, 0, 1)]
        [InlineData(3, 0, 2)]
        [InlineData(4, 1, 0)]
        [InlineData(5, 1, 1)]
        [InlineData(6, 1, 2)]
        [InlineData(7, 2, 0)]
        [InlineData(8, 2, 1)]
        [InlineData(9, 2, 2)]
        public void Player_input_matches_index(int value, int expectedRow, int expectedCol)
        {
            // Arrange
            Player player1 = new Player();
            Player player2 = new Player();


            // Act
            Position actual = Player.PositionForNumber(value);



            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expectedRow, actual.Row);
            Assert.Equal(expectedCol, actual.Column);

        }

    }
}
