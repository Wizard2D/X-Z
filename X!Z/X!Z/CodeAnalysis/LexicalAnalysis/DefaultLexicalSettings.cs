using System;
using System.Collections.Generic;
using System.Text;

namespace X_Z.CodeAnalysis.LexicalAnalysis
{
    public static class DefaultLexicalSettings
    {
        public static List<Tuple<TokenKind, string>> defaultDefinitions = new List<Tuple<TokenKind, string>>()
        {
            new Tuple<TokenKind, string>(TokenKind.NUMBER, "\\d+"),
            new Tuple<TokenKind, string>(TokenKind.PLUS, "\\+"),
            new Tuple<TokenKind, string>(TokenKind.MINUS, "\\-"),
            new Tuple<TokenKind, string>(TokenKind.POW, "\\^"),
            new Tuple<TokenKind, string>(TokenKind.DIVIDE, "\\/"),
            new Tuple<TokenKind, string>(TokenKind.MULTI, "\\*"),
            new Tuple<TokenKind, string>(TokenKind.EQUAL, "\\="),
            new Tuple<TokenKind, string>(TokenKind.COMPARE_HIGHER, "\\>"),
            new Tuple<TokenKind, string>(TokenKind.COMPARE_LOWER, "\\<"),
            new Tuple<TokenKind, string>(TokenKind.COMPARE_EQUAL, "\\=\\="),
            new Tuple<TokenKind, string>(TokenKind.COMPARE_HIGHEROREQ, "\\>\\="),
            new Tuple<TokenKind, string>(TokenKind.COMPARE_LOWEROREQ, "\\<\\="),
            new Tuple<TokenKind, string>(TokenKind.STRING, "\\\"(?=[.*])\\\""),
            new Tuple<TokenKind, string>(TokenKind.FUNCTION_KEYWORD, "function"),
            new Tuple<TokenKind, string>(TokenKind.ATTRIBUTE_KEYWORD, "attribute"),
            new Tuple<TokenKind, string>(TokenKind.FROM_KEYWORD, "from"),
            new Tuple<TokenKind, string>(TokenKind.IMPORT_KEYWORD, "import"),
            new Tuple<TokenKind, string>(TokenKind.PARENTHESIS_LEFT, "\\("),
            new Tuple<TokenKind, string>(TokenKind.PARENTHESIS_RIGHT, "\\)"),
            new Tuple<TokenKind, string>(TokenKind.DOT, "\\."),
            new Tuple<TokenKind, string>(TokenKind.WHITESPACE, @" "),
            new Tuple<TokenKind, string>(TokenKind.VARIABLE, "var"),
        };
    }
}
