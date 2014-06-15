using Jarp.Input.Interfaces;
using System;
using System.IO;

namespace Jarp.Input
{
    public class TextFileReader : IFileReader
    {
        private readonly TextReader _textReader;

        public TextFileReader(TextReader textReader)
        {
            _textReader = textReader;
        }

        public string[] Read(params string[] filePaths)
        {
            if (filePaths == null) throw new ArgumentNullException("filePaths");

            var srcStrings = new string[filePaths.Length];

            for (int i = 0; i < filePaths.Length; i++)
            {
                using (TextReader textReader = new StreamReader(filePaths[i]))
                {
                    string str = textReader.ReadToEnd();

                    srcStrings[i] = str;

                    textReader.Close();    
                }
            }
            return srcStrings;
        }
    }
}
