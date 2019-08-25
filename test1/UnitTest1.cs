using System;
using System.IO;
using Xunit;

namespace test1
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			using (var sw = new StringWriter())
			{
				string input = "1,20";
				string output = "1 + 20 = 21";
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