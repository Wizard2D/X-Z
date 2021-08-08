using System;
using System.Collections.Generic;
using System.Text;

namespace X_Z.CodeAnalysis.Parsing
{
    public class SyntaxNode : ISyntaxNode
    {
        public SyntaxKind Kind;
        public List<SyntaxNode> Members;
        public List<object> Values;

        public SyntaxNode(SyntaxKind kind, List<SyntaxNode> members = null, List<object> values = null)
        {
            Kind = kind;
            Members = members;
            Values = values;
        }
    }
}
