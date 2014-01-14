using NUnit.Framework;
using ProjectX.KeywordMapping;
using ProjectX.KeywordMapping.Domain;
using System.Collections.Generic;

namespace ProjectX._IntegrationTests.KeywordMapping
{
    [TestFixture]
    public class MapInitialiser_Should
    {
        private TargetLanguage _targetLanguage;

        private MapInitialiser _mapInitialiser;

        private Dictionary<string, string> _keyWordMap;
            
        [SetUp]
        public void Init()
        {
            _targetLanguage = TargetLanguage.CSharp;
            _mapInitialiser = new MapInitialiser(_targetLanguage);
            _keyWordMap = _mapInitialiser.GetKeywordMap(_targetLanguage);
        }

        [Test]
        public void GetKeywordMap_MapsTheCorrectNumberOfKeyValuePairs()
        {
            const int expected = 7;
            int actual = _keyWordMap.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetKeywordMap_Maps_Java_extends_Keyword_To_CSharp_Colon_Keyword()
        {
            const string expectedJava = "extends";
            const string expected = ":";

            string actual;

            _keyWordMap.TryGetValue(expectedJava, out actual);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetKeywordMap_Maps_Java_super_Keyword_To_CSharp_base_Keyword()
        {
            const string expectedJava = "super";
            const string expectedCSharp = "base";

            string actual;

            _keyWordMap.TryGetValue(expectedJava, out actual);

            Assert.AreEqual(expectedCSharp, actual);
        }

        [Test]
        public void GetKeywordMap_Maps_Java_boolean_Keyword_To_CSharp_bool_Keyword()
        {
            const string expectedJava = "boolean";
            const string expectedCSharp = "bool";

            string actual;

            _keyWordMap.TryGetValue(expectedJava, out actual);

            Assert.AreEqual(expectedCSharp, actual);
        }

        [Test]
        public void GetKeywordMap_Maps_Java_instanceof_Keyword_To_CSharp_is_Keyword()
        {
            const string expectedJava = "instanceof";
            const string expectedCSharp = "is";

            string actual;

            _keyWordMap.TryGetValue(expectedJava, out actual);

            Assert.AreEqual(expectedCSharp, actual);
        }

        [Test]
        public void GetKeywordMap_Maps_Java_synchronized_Keyword_To_CSharp_lock_Keyword()
        {
            const string expectedJava = "synchronized";
            const string expectedCSharp = "lock";

            string actual;

            _keyWordMap.TryGetValue(expectedJava, out actual);

            Assert.AreEqual(expectedCSharp, actual);
        }

        [Test]
        public void GetKeywordMap_Maps_Java_import_Keyword_To_CSharp_using_Keyword()
        {
            const string expectedJava = "import";
            const string expectedCSharp = "using";

            string actual;

            _keyWordMap.TryGetValue(expectedJava, out actual);

            Assert.AreEqual(expectedCSharp, actual);
        }

        [Test]
        public void GetKeywordMap_Maps_Java_private_Keyword_To_CSharp_internal_Keyword()
        {
            const string expectedJava = "private";
            const string expectedCSharp = "internal";

            string actual;

            _keyWordMap.TryGetValue(expectedJava, out actual);

            Assert.AreEqual(expectedCSharp, actual);
        }        
    }
}
