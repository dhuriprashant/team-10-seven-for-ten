using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
        }

        [Test]
        public void IsGameMapInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            
            testObj.Init ();
            Position actualStartingPosition = testObj.startingPoition;
            Assert.AreEqual(100,testObj.numPositions);
            Assert.AreEqual(0,actualStartingPosition.Coordinates.X);
            Assert.AreEqual(0,actualStartingPosition.Coordinates.Y);
        }
    }
}