using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using FluentAssertions;
using levelup;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class StartGameSteps
    {
        
        GameController testObj = new GameController();
        string characterNameBefore;
        int numPositionsBefore, xPositionBefore, yPositionBefore, numberOfMovesBefore, numPositionsAfter, xPositionAfter, yPositionAfter, numberOfMovesAfter;
        GameController.GameStatus gameStatus;

        
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
            gameStatus = testObj.GetStatus();
        }

        [Then(@"the character name should be (.*)")]
        public void checkCharacterName(string characterNameAfter)
        {
            StringAssert.AreEqualIgnoringCase(characterNameAfter, this.gameStatus.characterName);
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
            
            Assert.AreEqual(endY, gameStatus.currentPosition.y);
            
        }

        [Then(@"the number of moves after initiliazation is (.*)")]
        public void getNumberOfMoves(int numberOfMovesAfter)
        {
            Assert.AreEqual(0, numberOfMovesAfter);
        }
        
        
    }


}
