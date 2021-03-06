﻿using System;
using Jarp.Lex.Interfaces;

namespace Jarp.LexerBuilder
{
    public class Director
    {
        public ILexer Construct(Builder builder)
        {
            if(builder == null) throw new ArgumentNullException("builder");

            builder.InitOperators();
            builder.InitLiterals();
            builder.InitWhiteSpace();
            builder.InitKeywords();
            builder.InitSeparators();

            return builder.GetLexer();
        }
    }
}
