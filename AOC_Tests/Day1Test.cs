
using AOC2020.Days;

namespace AOC_Tests
{
    public class TestDay1Part1
    {
        [Fact]
        public void SampleTest1()
        {
            string[] sampleInput = ["1721", "979", "366", "299", "675", "1456"];
            var day = new Day1(sampleInput);
            var expected1 = "514579";
            var (result1, result2) = day.Solve();
            Assert.Equal(result1, expected1);
        }
    }
    public class TestDay1Part2
    {
        [Fact]
        public void SampleTest2()
        {
            string[] sampleInput = ["1721", "979", "366", "299", "675", "1456"];
            var day = new Day1(sampleInput);
            var expected2 = "241861950";
            var (result1, result2) = day.Solve();
            Assert.Equal(result2, expected2);
        }
    }
}
