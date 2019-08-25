using System;
using System.IO;
using Xunit;

namespace test7
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                string input = "//[***]\n11***22***33";
                input = input.Replace(System.Environment.NewLine, "\\n");
                string output = "11 + 22 + 33 = 66";
                using (var sr = new StringReader(input))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    restaurantCalculator.Program.Main();
                    var result = sw.ToString();
                    Assert.Equal(output, result);
                }
            }
        }
    }
}