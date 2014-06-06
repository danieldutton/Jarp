using Jarp.Lex.Interfaces;
using Jarp.Lex.Model;
using System.Text.RegularExpressions;

namespace Jarp.Lex
{
    public class JavaInitialiser : Initialiser
    {
        public JavaInitialiser(ILexer lexer) 
            : base(lexer)
        {
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
    }
}
