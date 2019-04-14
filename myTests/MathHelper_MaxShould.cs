using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MathHelper_MaxShould
    {
        [Fact]
        public void Return0GivenValuesOf0()
        {
            var mathHelper =  new MathHelper(); 

            var result = mathHelper.Max(0,0);

            if (result == 0)
            {
                System.Console.WriteLine("Success");
            }
            else
            {
                System.Console.WriteLine("Failed");
            }
        }
    }
}
