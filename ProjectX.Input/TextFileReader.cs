using System.IO;
using ProjectX.Input.Interfaces;
using System;

namespace ProjectX.Input
{
    public class TextFileReader : IFileReader
    {
        public string[] Read(params string[] filePaths)
        {
            if (filePaths == null) throw new ArgumentNullException("filePaths");

            var srcStrings = new string[filePaths.Length];

            for (int i = 0; i < filePaths.Length; i++)
            {
                TextReader textReader = new StreamReader(filePaths[i]);

                string str = textReader.ReadToEnd();

                srcStrings[i] = str;

                textReader.Close();
            }
            return srcStrings;
        }
    }
}
