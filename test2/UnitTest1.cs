using System;
using System.IO;
using Xunit;

namespace test2
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			using (var sw = new StringWriter())
			{
				string input = "1,20,5,tytyt";
				string output = "1 + 20 + 5 + 0 = 26";
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