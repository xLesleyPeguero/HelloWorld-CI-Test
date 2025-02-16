using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HelloWorldProgram
{
    public class HelloWorldTests
    {
        [Fact]
        public void SayHi_Should_ReturnHelloWorld()
        {
            string result = Program.SayHi();
            Assert.Equal("Hello world!", result);
        }
    }
}
