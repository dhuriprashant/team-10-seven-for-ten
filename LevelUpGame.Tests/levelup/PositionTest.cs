using NUnit.Framework;
using levelup;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class PositionTest{

        private Position? testObj;

        [Test]
        public void IsPositionCreated()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            
            testObj = new Position(1,2);
        
            Point actualCoordinate = testObj.Coordinates;
            Assert.NotNull(testObj.Coordinates);
            Assert.AreEqual(1,actualCoordinate.X);
            Assert.AreEqual(2,actualCoordinate.Y);
            
        }

    }
}