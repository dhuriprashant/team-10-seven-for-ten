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

        
        [Given(@"the character name is (.*)")]
        public void givenThecharacterNameBefore(string characterNameBefore)
        {
            this.characterNameBefore = characterNameBefore;
        }


        [Given(@"number of positions is (.*)")]
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

        [When (@"game starts")]
        public void whenGameStarts()
        {
            testObj.StartGame();
        }

        [Then(@"the character name should be (.*)")]
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

        [Then(@"the current x position should be (.*)")]
        public void checkXCoordinates(int endX)
        {
            Assert.NotNull(this.xPositionAfter, "Expected position not null");
            Assert.AreEqual(xPositionAfter, this.xPositionAfter);
        }

        [Then(@"the current y position should be (.*)")]
        public void checkYCoordinates(int endY)
        {
            /*
            Assert.NotNull(this.currentPosition, "Expected position not null");
            Assert.AreEqual(endY, this.currentPosition.Y);
            */
        }

        [Then(@"the number of moves after initiliazation is (.*)")]
        public void getNumberOfMoves(int numberOfMovesAfter)
        {
            Assert.NotNull(this.numberOfMovesAfter,"Expected number of moves not null");
            Assert.AreNotEqual(this.numberOfMovesAfter, this.numberOfMovesBefore);
            Assert.AreEqual(this.numberOfMovesAfter, this.numberOfMovesBefore + 1);
        }

        
    }


}
