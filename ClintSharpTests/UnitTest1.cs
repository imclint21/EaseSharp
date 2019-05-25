using System;
using System.Threading.Tasks;
using Xunit;

namespace ClintSharpTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var t = new Task(() =>
            {
                int i = 5 - 5;
                Console.WriteLine(5 / i);
            });
            t.Start();
        }
    }
}
