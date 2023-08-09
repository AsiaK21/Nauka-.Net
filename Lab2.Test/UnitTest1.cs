using Lab2;
namespace Lab2.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnProperString()
        {
            var data = 0.05;
            var result = MyFormatter.FormatUsdPrice(data);
            // Assert.StartsWith("$", result);
            // Assert.Contains(".", result);
            Assert.Equal("$0.05", result);

        }
    }
}