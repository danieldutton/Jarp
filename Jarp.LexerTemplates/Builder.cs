using Jarp.Lex.Interfaces;

namespace Jarp.LexerBuilder
{
    public abstract class Builder
    {
        private readonly ILexer _lexer;

        protected ILexer Lexer { get { return _lexer; } }

        protected Builder()
        {            
        }

        protected Builder(ILexer lexer)
        {
            _lexer = lexer;
        }

        public abstract void InitOperators();

        public abstract void InitLiterals();

        public abstract void InitWhiteSpace();

        public abstract void InitKeywords();

        public abstract void InitSeparators();

        public abstract ILexer GetLexer();
    }
}
