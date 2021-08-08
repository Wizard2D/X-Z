using System;
using System.Collections.Generic;
using X_Z.CodeAnalysis.LexicalAnalysis;
using X_Z.CodeAnalysis.Parsing;
using X_Z.CodeAnalysis.Compiling;
namespace X_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Lexer lexer = new Lexer(DefaultLexicalSettings.defaultDefinitions);
            string testcode = "10+10+10+10-4";
            string[] splitCode = lexer.splitByDelimiters(testcode);
            List<Token> tknsList = new List<Token>();
            foreach (string s in splitCode) {
                Token tk = lexer.Tokenize(s);
                tknsList.Add(tk);
            }
            tknsList = lexer.removeWSandEmptyUndefs(tknsList);
            Parser parser = new Parser();
            SyntaxRoot root = parser.Parse(tknsList);
            Interpreter intrp = new Interpreter();
            intrp.Interpret(root);
        }
    }
}
