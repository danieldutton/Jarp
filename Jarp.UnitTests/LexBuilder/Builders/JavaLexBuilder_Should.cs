using System.Text.RegularExpressions;
using Jarp.Lex.Interfaces;
using Jarp.Lex.Model;
using Jarp.LexerBuilder.Builders;
using Moq;
using NUnit.Framework;

namespace Jarp.Tests.LexBuilder.Builders
{
    [TestFixture]
    public class JavaLexBuilder_Should
    {
        [Test]
        public void InitOperators_AddDefinitionIsCalled_ExactlyOnce()
        {
            var lexer = new Mock<ILexer>();

            var sut = new JavaLexBuilder(lexer.Object);
            sut.InitOperators();

            lexer.Verify(x => x.AddDefinition(It.IsAny<TokenDefinition>()), Times.Once());
        }

        [Test]
        public void InitOperators_AddDefinitionIsCalled_WithCorrectData()
        {
            var tokenTd = new TokenDefinition("(operator)", new Regex(@"\*|\/|\+|\-"));

            var lexer = new Mock<ILexer>();

            var sut = new JavaLexBuilder(lexer.Object);
            sut.InitOperators();

            lexer.Verify(x => x.AddDefinition(It.Is<TokenDefinition>(y => y == tokenTd)));
        }

        [Test]
        public void InitLiterals_AddDefinitionIsCalled_ExactlyOnce()
        {
            var lexer = new Mock<ILexer>();

            var sut = new JavaLexBuilder(lexer.Object);
            sut.InitOperators();

            lexer.Verify(x => x.AddDefinition(It.IsAny<TokenDefinition>()), Times.Once());
        }

        [Test]
        public void InitWhiteSpace_AddDefinitionIsCalled_ExactlyOnce()
        {
            var lexer = new Mock<ILexer>();

            var sut = new JavaLexBuilder(lexer.Object);
            sut.InitOperators();

            lexer.Verify(x => x.AddDefinition(It.IsAny<TokenDefinition>()), Times.Once());
        }

        [Test]
        public void InitKeywords_AddDefinitionIsCalled_ExactlyOnce()
        {
            var lexer = new Mock<ILexer>();

            var sut = new JavaLexBuilder(lexer.Object);
            sut.InitOperators();

            lexer.Verify(x => x.AddDefinition(It.IsAny<TokenDefinition>()), Times.Once());
        }

        [Test]
        public void InitSeparators_AddDefinitionIsCalled_ExactlyOnce()
        {
            var lexer = new Mock<ILexer>();

            var sut = new JavaLexBuilder(lexer.Object);
            sut.InitOperators();

            lexer.Verify(x => x.AddDefinition(It.IsAny<TokenDefinition>()), Times.Once());
        }

        [Test]
        public void GetLexer_returnsALexerInstance()
        {
            var lexer = new Mock<ILexer>();

            var sut = new JavaLexBuilder(lexer.Object);
            var result = sut.GetLexer();
            
            Assert.IsInstanceOf<ILexer>(result);
        }
    }
}
