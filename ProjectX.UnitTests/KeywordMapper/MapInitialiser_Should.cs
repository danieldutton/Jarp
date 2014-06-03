using NUnit.Framework;
using System;
using ProjectX.KeywordMapper;
using ProjectX.KeywordMapper.Domain;

namespace ProjectX.Tests.KeywordMapper
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
            new MapInitialiser(TargetLanguage.CSharp);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetKeywordMap_Fooz()
        {
            new MapInitialiser(TargetLanguage.CSharp);
        }

        [Test]
        public void GetKeywordMap_FireAStartEventUponInvocation()
        {
            bool wasCalled = false;

            _mapInitialiser.Start += (o, e) => wasCalled = true;
            _mapInitialiser.GetKeywordMap(TargetLanguage.CSharp);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void GetKeywordMap_FireAnInProgressEventUponInvocation()
        {
            bool wasCalled = false;

            _mapInitialiser.InProgress += (o, e) => wasCalled = true;
            _mapInitialiser.GetKeywordMap(TargetLanguage.CSharp);

            Assert.IsTrue(wasCalled);
        }

        [Test]
        public void GetKeywordMap_FireACompleteEventUponInvocation()
        {
            bool wasCalled = false;

            _mapInitialiser.Complete += (o, e) => wasCalled = true;
            _mapInitialiser.GetKeywordMap(TargetLanguage.CSharp);

            Assert.IsTrue(wasCalled);
        }

        [TearDown]
        public void TearDown()
        {
            _mapInitialiser = null;
        }
    }
}
