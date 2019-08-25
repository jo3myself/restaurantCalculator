using System;
using System.IO;
using Xunit;

namespace test6
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                string input = "//;\n2;5";
                input = input.Replace(System.Environment.NewLine, "\\n");
                string output = "2 + 5 = 7";
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