using Jarp.Lex.Model;
using NUnit.Framework;

namespace Jarp.Tests.Lex.Model
{
    [TestFixture]
    public class TokenPosition_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new TokenPosition(1, 2, 3);

            const string expected = "";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
