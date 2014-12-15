using Jarp.Interfaces;
using Jarp.KeywordMapper.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Jarp.KeywordMapper
{
    public class MapInitialiser : IProgressable
    {
        public TargetLanguage TargetLanguage { get; private set; }

        public event EventHandler Start;

        public event EventHandler InProgress;

        public event EventHandler Complete;

        private string _filePath;


        public MapInitialiser(TargetLanguage targetLanguage)
        {
            TargetLanguage = targetLanguage;
            SetTargetLanguage();
        }

        private void SetTargetLanguage()
        {
            if (TargetLanguage == TargetLanguage.CSharp)
                _filePath = "csharp_keywords.xml";

            if (TargetLanguage == TargetLanguage.VisualBasic)
                _filePath = "vb_keywords.xml";    
        }

        public Dictionary<string, string> GetKeywordMap(TargetLanguage targetLanguage)
        {
            OnInitStart();
            
            XDocument xDoc = XDocument.Load(_filePath);

            OnInitInProgress();

            IEnumerable<XElement> xElements = xDoc.Descendants("pairs");

            Dictionary<string, string> keyWordDictionary = PopulateKeywordMap(xElements);

            OnInitComplete();

            return keyWordDictionary;
        }

        private Dictionary<string, string> PopulateKeywordMap(IEnumerable<XElement> elements)
        {            
            var keywordMap = elements.ToDictionary(e => e.Element("key")
                .Value.ToString(), 
                e => e.Element("value")
                    .Value
                    .ToString());

            return keywordMap;
        }

        protected virtual void OnInitStart()
        {
            EventHandler handler = Start;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnInitInProgress()
        {
            EventHandler handler = InProgress;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnInitComplete()
        {
            EventHandler handler = Complete;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
