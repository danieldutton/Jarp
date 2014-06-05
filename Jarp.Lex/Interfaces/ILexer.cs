using ProjectX.Lex.Model;
using System.Collections.Generic;

namespace ProjectX.Lex.Interfaces
{
    public interface ILexer
    {
        void AddDefinition(TokenDefinition tokenDefinition);
        
        IEnumerable<Token> Tokenize(string source);
    }
}
