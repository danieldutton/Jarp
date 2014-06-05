using System;
using System.Text.RegularExpressions;
using Jarp.Lex.Model;

namespace Jarp.Lex
{
    public class TokensierInit
    {
        public void Tokenise(string srcCode)
        {
            var lexer = new Lexer();

            lexer.AddDefinition(new TokenDefinition("(operator)", new Regex(@"\*|\/|\+|\-")));

            lexer.AddDefinition(new TokenDefinition("(literal)", new Regex(@"\d+")));

            lexer.AddDefinition(new TokenDefinition("(white-space)", new Regex(@"\s+"), true));

            lexer.AddDefinition(new TokenDefinition("(keyword)", new Regex(@"abstract|assert|boolean|break|
                byte|case|catch|char|class|const|continue|default|do|double|else|enum|hrow|throws|extends|final
                |finally|float|for|goto|if|implements|import|instanceof|int|interface|long|native|new|package|
                private|protected|public|return|short|static|strictfp|super|switch|synchronized|this|transient|
                try|void|volatile|while")
                ));

            lexer.AddDefinition(new TokenDefinition("(separator)", new Regex(@"{|}")));

            var tokens = lexer.Tokenize(srcCode);

            foreach (var token in tokens)
                Console.WriteLine(token);

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
