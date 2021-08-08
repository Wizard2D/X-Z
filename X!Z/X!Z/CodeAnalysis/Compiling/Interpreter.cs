using System;
using System.Collections.Generic;
using System.Text;
using X_Z.CodeAnalysis.Parsing;
//dont use this pls.
namespace X_Z.CodeAnalysis.Compiling
{
    public class Interpreter
    {
        public void Interpret(SyntaxRoot root)
        {
            foreach(var t in root.Members)
            {
                switch (t.Kind)
                {
                    case SyntaxKind.AddExpression:
                        Console.WriteLine((int)t.Values[0] + (int)t.Values[1]);
                        break;
                    case SyntaxKind.SubstractExpression:
                        Console.WriteLine((int)t.Values[0] - (int)t.Values[1]);
                        break;

                }
            }
        }
    }
}
