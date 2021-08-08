using System;
using System.Collections.Generic;
using System.Text;

namespace X_Z.CodeAnalysis.Parsing
{
    public class SyntaxRoot : ISyntaxNode
    {
        public SyntaxKind Kind { get { return SyntaxKind.Root; } }
        public List<SyntaxNode> Members = new List<SyntaxNode>();

        public void AddSyntaxNode(SyntaxNode node)
        {
            Members.Add(node);
        }
    }
}
