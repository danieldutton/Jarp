using System.Text.RegularExpressions;
using Jarp.Lex.Model;
using NUnit.Framework;

namespace Jarp.IntegrationTests.Lex.Model
{
    [TestFixture]
    public class TokenDefinition_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new TokenDefinition("Type", new Regex("pattern"));

            const string expected = "[TokenDefinition] IsIgnored: False Regex: pattern Type: Type";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
            
        }
    }
}
