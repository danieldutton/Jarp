﻿using System.Diagnostics;
using Jarp.Lex.Model;
using NUnit.Framework;

namespace Jarp.Tests.Lex.Model
{
    [TestFixture]
    public class Token_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new Token("Type", "Value", new TokenPosition(1, 2, 3));

            const string expected = "";
            string actual = sut.ToString();

            Debug.WriteLine(sut.ToString());
            Assert.AreEqual(expected, actual);
        }
    }
}
