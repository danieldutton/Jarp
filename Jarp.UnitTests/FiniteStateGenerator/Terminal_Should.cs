using Jarp.FiniteStateGenerator;
using NUnit.Framework;

namespace Jarp.Tests.FiniteStateGenerator
{
    [TestFixture]
    public class Terminal_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectValue()
        {
            var sut = new Terminal<string>("Input1", "Input2");

            const string expected = "[Terminal`1] Input:Input1 Output:Input2";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
