using System;
using System.IO;
using Xunit;

namespace test3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                string input = "1\n2,3,aaa";
                input = input.Replace(System.Environment.NewLine, "\\n");
                string output = "1 + 2 + 3 + 0 = 6";
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