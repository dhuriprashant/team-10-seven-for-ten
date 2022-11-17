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
        String Name = "";
        CharacterSteps testObj = new CharacterSteps();
        [Given(@"the character has no name")]
        public void givenCharacterHasNoName(string Name)
        {
        this.Name = Name;
        }

        [When (@"the game starts")]
        public void whenTheGameStarts(){
            testObj.Name = "";
        }

        [Then(@"assign character default name")]
        public void setDefaultCharacterName(){
            Assert.NotNull(this.Name, "CharacterName is not blank");
        }
    }

}
/*
    Given the character has no name <startingName>
    When the game starts
    Then assign character default name <CharacterName>
*/