using CS_Basic_App_GitHub;
using Xunit;
namespace CS_Basic_App_Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            // Arrange
            Class1 tp = new Class1();
            // Act
            var result = tp.Name;
            // Assert
            Assert.Equal("Cole Sherer - The Code Master", result);
        }
    }
}