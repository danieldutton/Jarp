using System.Collections.Generic;
using Jarp.Lex.Model;

namespace Jarp.Lex.Interfaces
{
    public interface ILexer
    {
        void AddDefinition(TokenDefinition tokenDefinition);
        
        IEnumerable<Token> Tokenize(string source);
    }
}
