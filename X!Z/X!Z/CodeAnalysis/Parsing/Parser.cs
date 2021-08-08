using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using X_Z.CodeAnalysis.LexicalAnalysis;

namespace X_Z.CodeAnalysis.Parsing
{
    public class Parser
    {
        int index = 0;

        SyntaxRoot root;
        Token currentToken;
        List<Token> tokens;
        public Token LookAhead()
        {
            if(index+1 < tokens.Count)
                return tokens[index + 1];
            return new Token(TokenKind.EOF, "");
        }
        public Token LookAheadBy(int count)
        {
            return tokens[index + count];
        }
        public void Increment()
        {
            if (index + 1 < tokens.Count)
                currentToken = tokens[index++];
        }
        public int ParseExpression()
        {
            if (LookAhead().kind != TokenKind.PLUS && LookAhead().kind != TokenKind.MINUS && LookAhead().kind != TokenKind.MULTI && LookAhead().kind != TokenKind.DIVIDE && LookAhead().kind != TokenKind.POW)
                return ParseNumber();
            int left = ParseNumber();
            var operation = currentToken.kind; Increment();
            int right = ParseExpression();
            Console.WriteLine(operation);
            switch (operation) {
                case TokenKind.PLUS:
                    return left + right;
                case TokenKind.MINUS:
                    return left - right;
                case TokenKind.MULTI:
                    return left * right;
                case TokenKind.DIVIDE:
                    return left / right;
                case TokenKind.POW:
                    return (int)Math.Pow(left, right);
            }
            return 0;
        }
        public int ParseNumber()
        {
            Console.WriteLine("'" + currentToken.refers + "'");
            var val = int.Parse(currentToken.refers);
            Increment();
            return val;
        }
            public SyntaxRoot Parse(List<Token> tokenList)
            {
                
                tokens = tokenList;
                root = new SyntaxRoot();
                while (index < tokens.Count)
                {
                    currentToken = tokens[index];
                    switch (currentToken.kind)
                    {
                        case TokenKind.NUMBER: Console.WriteLine(ParseExpression()); break;
                    }
                    Increment();
                }
                return root;
            }
        
    }
}
