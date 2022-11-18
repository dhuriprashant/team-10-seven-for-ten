using TechTalk.SpecFlow;
using levelup;
using System.Drawing;
using System;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class CharacterSteps
    {
        static String DEFAULT_NAME = "LevelUpPlayer";
        string Name = "";
        GameController testObj = new GameController();

        [Given(@"the character has no name (.*)")]
        public void givenCharacterHasNoName(string startingName)
        {
            this.Name = startingName;
        }

        [When (@"the game starts")]
        public void whenTheGameStarts(){
            testObj.StartGame();
        }

        [Then(@"assign character default name (.*)")]
        public void setDefaultCharacterName(string Name){
            Assert.NotNull(this.Name, testObj.GetStatus().playerName);
        }
    }

}
