using Jarp.Lex;
using Jarp.Lex.Interfaces;
using Jarp.LexerBuilder;
using Moq;
using NUnit.Framework;
using System;

namespace Jarp.Tests.LexBuilder
{
    [TestFixture]
    public class Director_Should
    {
        private Mock<Builder> _fakeBuilder;

        private Director _sut;

        [SetUp]
        public void Init()
        {
            _sut = new Director();
            _fakeBuilder = new Mock<Builder>();
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Construct_ThrowArgumentNullException_IfBuilderParamIsNull()
        {
            _sut.Construct(null);
        }

        [Test]
        public void Construct_CallInitOperators_ExactlyOnce()
        {
            _sut.Construct(_fakeBuilder.Object);

            _fakeBuilder.Verify(x => x.InitOperators(), Times.Once());
        }

        [Test]
        public void Construct_CallInitLiterals_ExactlyOnce()
        {
            _sut.Construct(_fakeBuilder.Object);

            _fakeBuilder.Verify(x => x.InitLiterals(), Times.Once());
        }

        [Test]
        public void Construct_CallInitWhiteSpace_ExactlyOnce()
        {
            _sut.Construct(_fakeBuilder.Object);

            _fakeBuilder.Verify(x => x.InitWhiteSpace(), Times.Once());
        }

        [Test]
        public void Construct_CallInitKeywords_ExactlyOnce()
        {
            _sut.Construct(_fakeBuilder.Object);

            _fakeBuilder.Verify(x => x.InitKeywords(), Times.Once());
        }

        [Test]
        public void Construct_CallInitSeparators_ExactlyOnce()
        {
            _sut.Construct(_fakeBuilder.Object);

            _fakeBuilder.Verify(x => x.InitSeparators(), Times.Once());
        }

        [Test]
        public void Construct_ReturnAnInstanceOf_ILexer()
        {
            _fakeBuilder.Setup(x => x.GetLexer())
                .Returns(() => new Lexer());
            
            ILexer result = _sut.Construct(_fakeBuilder.Object);

            Assert.IsInstanceOf<ILexer>(result);
        }

        [TearDown]
        public void TearDown()
        {
            _fakeBuilder = null;
            _sut = null;
        }
    }
}
