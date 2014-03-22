using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebRole.Tests
{
    public class MyTests
    {
        [Fact]
        public void TestA()
        {
            Assert.Equal(2, 2);
        }

        [Fact]
        public void TestB()
        {
            Assert.Equal(8, 8);
        }
    }
}
