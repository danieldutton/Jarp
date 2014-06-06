using Jarp.Lex.Interfaces;
using Jarp.Lex.Model;
using System.Text.RegularExpressions;

namespace Jarp.LexerBuilder.Builders
{
    public class JavaLexBuilder : Builder 
    {
        public JavaLexBuilder(ILexer lexer) 
            : base(lexer)
        {
        }

        public override void InitOperators()
        {
            Lexer.AddDefinition(new TokenDefinition("(operator)", new Regex(@"\*|\/|\+|\-")));
        }

        public override void InitLiterals()
        {
            Lexer.AddDefinition(new TokenDefinition("(literal)", new Regex(@"\d+")));
        }

        public override void InitWhiteSpace()
        {
            Lexer.AddDefinition(new TokenDefinition("(white-space)", new Regex(@"\s+"), true));
        }

        public override void InitKeywords()
        {
            Lexer.AddDefinition(new TokenDefinition("(keyword)", new Regex(@"abstract|assert|boolean|break|
                byte|case|catch|char|class|const|continue|default|do|double|else|enum|hrow|throws|extends|final
                |finally|float|for|goto|if|implements|import|instanceof|int|interface|long|native|new|package|
                private|protected|public|return|short|static|strictfp|super|switch|synchronized|this|transient|
                try|void|volatile|while")
                ));
        }

        public override void InitSeparators()
        {
            Lexer.AddDefinition(new TokenDefinition("(separator)", new Regex(@"{|}")));
        }

        public override ILexer GetLexer()
        {
            return Lexer;
        }
    }
}
