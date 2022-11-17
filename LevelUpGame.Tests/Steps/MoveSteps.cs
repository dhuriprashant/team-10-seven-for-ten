using TechTalk.SpecFlow;
using levelup;
using System.Drawing;
using System;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class MoveSteps
    {
        GameController testObj = new GameController();
        int startX, startY, endX, endY, numberOfMovesBefore, numberOfMovesAfter ;
        GameController.DIRECTION direction;
        Point currentPosition;


        [Given(@"the character starts at position with XCoordinates (.*)")]
        public void givenTheCharacterStartsAtX(int startX)
        {
            this.startX = startX;
        }

        [Given (@"starts at YCoordinates (.*)")]
        public void givenTheCharacterStartsAtY(int startY)
        {
            this.startY = startY;
        }

        [Given (@"the number of moves is (.*)")]
        public void givenTheNumOfMovesBeforeMove(int numberOfMovesBefore)
        {
            this.numberOfMovesBefore = numberOfMovesBefore;
        }

        [Given(@"the player choses to move in (.*)")]
        public void givenPlayerChoosesDirection(string direction)
        {
            this.direction = (GameController.DIRECTION) Enum.Parse(typeof(GameController.DIRECTION), direction);

        }

        [When (@"the character moves")]
        public void whenTheCharacterMoves()
        {
            testObj.SetCharacterPoistion(new Point(this.startX, this.startY));
            testObj.Move(this.direction);
            GameController.GameStatus status = testObj.GetStatus();
            this.currentPosition = status.currentPosition;
            this.numberOfMovesAfter = numberOfMovesBefore + 1;

        }

        [Then(@"the character is now at position with XCoordinates (.*)")]
        public void checkXCoordinates(int endX)
        {
            Assert.NotNull(this.currentPosition, "Expected position not null");
            Assert.AreEqual(endX, this.currentPosition.X);
        }

        [Then(@"YCoordinates (.*)")]
        public void checkYCoordinates(int endY)
        {
            Assert.NotNull(this.currentPosition, "Expected position not null");
            Assert.AreEqual(endY, this.currentPosition.Y);
        }

        [Then(@"the new number of moves is (.*)")]
        public void getNumberOfMoves(int numberOfMovesAfter)
        {
            Assert.NotNull(this.numberOfMovesAfter,"Expected number of moves not null");
            Assert.AreNotEqual(this.numberOfMovesAfter, this.numberOfMovesBefore);
            Assert.AreEqual(this.numberOfMovesAfter, this.numberOfMovesBefore + 1);
        }
    }


}
