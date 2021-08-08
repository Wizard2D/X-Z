using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace X_Z.CodeAnalysis.LexicalAnalysis
{
    public class Lexer
    {
        List<Tuple<TokenKind, string>> lexDefinitions;
        string delimiters = @"\s;=:+-/\*\^><()\{\}\[\]";

        public Tuple<TokenKind, string> matchesDefinition(string expr)
        {
            foreach(var i in lexDefinitions)
            {
                if (Regex.IsMatch(expr, i.Item2))
                    return i;
            }
            return null;
        }

        public string[] splitByDelimiters(string what)
        {

            //string whatt = Regex.Replace(what, "", S);
            string[] strsp = Regex.Split(what, @"([;\s=:+-\/\*\^><\(\)\{\}\[\]])").Where(s => !string.IsNullOrEmpty(s)).ToArray();
            return strsp;
            
        }
        public List<Token> removeWSandEmptyUndefs(List<Token> tkList)
        {
            List<Token> tkns = new List<Token>();
            foreach (Token tk in tkList)
            {
                if (tk.kind != TokenKind.WHITESPACE)
                {
                    tkns.Add(tk);
                    continue;
                }
            }
            return tkns;
        }
            public Token Tokenize(string what)
        {
            var c = matchesDefinition(what);
            if (c != null)
            {
               return new Token(c.Item1, what);
            }
            return new Token(TokenKind.UNDEF, what);
        }

        public Lexer(List<Tuple<TokenKind, string>> definitions)
        {
            lexDefinitions = definitions;
        }
    }
}
