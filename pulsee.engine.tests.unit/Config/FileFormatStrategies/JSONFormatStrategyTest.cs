using Moq;
using NUnit.Framework;

namespace pulsee.engine.tests.unit.Config.FileFormatStrategies
{
    public class JSONFormatStrategyTest
    {
        private Mock<engine.IO.File.FileReader> fileReaderMock;
        private engine.Config.FileFormatStrategies.JSONFormatStrategy _JSONFormatStrategy;

        [SetUp]
        public void Setup()
        {
            fileReaderMock = new Mock<IO.File.FileReader>();

            _JSONFormatStrategy = new engine.Config.FileFormatStrategies.JSONFormatStrategy();
        }

        [Test]
        public void TestRead()
        {
            
        }
    }
}
