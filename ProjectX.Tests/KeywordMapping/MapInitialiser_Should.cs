using NUnit.Framework;
using ProjectX.KeywordMapping;
using ProjectX.KeywordMapping.Domain;
using System;

namespace ProjectX._Tests.KeywordMapping
{
    public class MapInitialiser_Should
    {
        private TargetLanguage _targetLanguage;

        private MapInitialiser _mapInitialiser;

        [SetUp]
        public void Init()
        {
            _targetLanguage = TargetLanguage.CSharp;
            _mapInitialiser = new MapInitialiser(_targetLanguage);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetKeywordMap_Foo()
        {
            new MapInitialiser("Test", null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetKeywordMap_Fooz()
        {
            new MapInitialiser(null, "Test");
        }

        [Test]
        public void GetKeywordMap_FireAStartEventUponInvocation()
        {
            bool wasCalled = false;

            _mapInitialiser.Start += (o, e) => wasCalled = true;
            _mapInitialiser.GetKeywordMap();

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void GetKeywordMap_FireAnInProgressEventUponInvocation()
        {
            bool wasCalled = false;

            _mapInitialiser.InProgress += (o, e) => wasCalled = true;
            _mapInitialiser.GetKeywordMap();

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void GetKeywordMap_FireACompleteEventUponInvocation()
        {
            bool wasCalled = false;

            _mapInitialiser.Complete += (o, e) => wasCalled = true;
            _mapInitialiser.GetKeywordMap();

            Assert.IsTrue(wasCalled);
        }

        [TearDown]
        public void TearDown()
        {
            _mapInitialiser = null;
        }
    }
}
