using System;
using System.Collections.Generic;
using System.Text;

namespace X_Z.CodeAnalysis.LexicalAnalysis
{
    public enum TokenKind : byte
    {
        NUMBER,
        PLUS,
        MINUS,
        DIVIDE,
        POW,
        MULTI,
        COMPARE_HIGHER,
        COMPARE_LOWER,
        COMPARE_HIGHEROREQ,
        COMPARE_LOWEROREQ,
        COMPARE_EQUAL,
        PARENTHESIS_LEFT,
        PARENTHESIS_RIGHT,
        DOT,
        VARIABLE,
        EQUAL,
        STRING,
        FUNCTION_KEYWORD,
        IMPORT_KEYWORD,
        FROM_KEYWORD,
        ATTRIBUTE_KEYWORD,
        //RESERVED TYPES
        WHITESPACE = 254,
        EOF = 253,
        UNDEF = 255
    }
}
