using System.Text.RegularExpressions;

namespace ProjectX.Lex.Model
{
    public class TokenDefinition
    {
        public bool IsIgnored { get; private set; }
        
        public Regex Regex { get; private set; }
        
        public string Type { get; private set; }

        public TokenDefinition(string type, Regex regex)
            : this(type, regex, false)
        {
        }

        public TokenDefinition(string type, Regex regex, bool isIgnored)
        {
            Type = type;
            Regex = regex;
            IsIgnored = isIgnored;
        }

        public override string ToString()
        {
            return string.Format("[{0}] IsIgnored: {1} Regex: {2} Type: {3}",
                                 GetType().Name, IsIgnored, Regex, Type);
        }
    }
}
