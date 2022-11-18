using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using FluentAssertions;
using levelup;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class StartGame
    {
        GameController testObj = new GameController();
        string characterNameBefore, characterNameAfter;
        int numPositionsBefore, xPositionBefore, yPositionBefore, numberOfMovesBefore, numPositionsAfter, xPositionAfter, yPositionAfter, numberOfMovesAfter;

        [Given(@"The character name is (.*)")]
        public void givenThecharacterNameBefore(string characterNameBefore)
        {
            this.characterNameBefore = characterNameBefore;
        }

        [Given(@"The number of positions is (.*)")]
        public void givenTheNumPositionsBefore(int numPositionsBefore)
        {
            this.numPositionsBefore = numPositionsBefore;
        }

        [Given (@"the current x position is (.*)")]
        public void givenThexPositionBefore(int xPositionBefore)
        {
            this.xPositionBefore = xPositionBefore;
        }

        [Given (@"the current y position is (.*)")]
        public void givenTheyPositionBefore(int yPositionBefore)
        {
            this.yPositionBefore = yPositionBefore;
        }

        [Given (@"the number of moves before initiliazation is (.*)")]
        public void givenTheNumberOfMovesBefore(int numberOfMovesBefore)
        {
            this.numberOfMovesBefore = numberOfMovesBefore;
        }

        [When (@"the game starts")]
        public void whenTheGameStarts()
        {
            testObj.StartGame();
        }

        [Then(@"The character name is (.*)")]
        public void checkCharacterName(string characterNameAfter)
        {
            Assert.NotNull(this.characterNameAfter, "Expected character name not null");
            Assert.AreEqual("DEFAULT_NAME", this.characterNameAfter);
        }

        [Then(@"the number of positions will be (.*)")]
        public void checkNumberOfPositions(int endX)
        {
            Assert.NotNull(this.numPositionsAfter, "Expected number of position not null");
            Assert.AreEqual(xPositionAfter, 100);
        }

        [Then(@"the character is now at position with XCoordinates (.*)")]
        public void checkXCoordinates(int endX)
        {
            Assert.NotNull(this.xPositionAfter, "Expected position not null");
            Assert.AreEqual(xPositionAfter, this.xPositionAfter);
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
