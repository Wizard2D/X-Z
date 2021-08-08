using System;
using System.Collections.Generic;
using System.Text;

namespace X_Z.CodeAnalysis.Parsing
{
    public enum SyntaxKind : byte
    {
        ImportFromDeclaration,
        VariableDeclaration,
        FunctionDeclaration,
        AttributeDeclaration,
        AddExpression,
        SubstractExpression,
        MultiExpression,
        DivisionExpression,
        PowExpression,
        Root = 255
    }
}
