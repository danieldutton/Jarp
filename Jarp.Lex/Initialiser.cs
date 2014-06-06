using Jarp.Lex.Interfaces;
using Jarp.Lex.Model;
using System.Text.RegularExpressions;

namespace Jarp.Lex
{
    public abstract class Initialiser
    {
        private readonly ILexer _lexer;

        protected ILexer Lexer{get { return _lexer; }}

        protected Initialiser(ILexer lexer)
        {
            _lexer = lexer;
        }
        //maybe consider storing values/regex in xml and reading them in
        public void InitOperators()
        {
            _lexer.AddDefinition(new TokenDefinition("(operator)", new Regex(@"\*|\/|\+|\-")));    
        }

        public void InitLiterals()
        {
            _lexer.AddDefinition(new TokenDefinition("(literal)", new Regex(@"\d+")));    
        }

        public void InitWhiteSpace()
        {
            _lexer.AddDefinition(new TokenDefinition("(white-space)", new Regex(@"\s+"), true));    
        }

        public abstract void InitKeywords();


        public void InitSeparators()
        {
            _lexer.AddDefinition(new TokenDefinition("(separator)", new Regex(@"{|}")));    
        }
    }
}
