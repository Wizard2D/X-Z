using System;
using System.Collections.Generic;
using System.Text;

namespace X_Z.CodeAnalysis.LexicalAnalysis
{
    public class Token
    {
        public TokenKind kind;
        public string refers;

        public Token(TokenKind k, string r)
        {
            kind = k;
            refers = r;
        }
    }
}
