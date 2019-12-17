namespace compiler.CodeAnalysis.Syntax
{
    public sealed class ElseClauseSyntax : SyntaxNode
    {
        public ElseClauseSyntax (SyntaxToken elseKeyword, StatementSyntax elseStatment)
        {
            ElseKeyword = elseKeyword;
            ElseStatment = elseStatment;
        }

        public override SyntaxKind Kind => SyntaxKind.ElseClause;

        public SyntaxToken ElseKeyword { get; }
        public StatementSyntax ElseStatment { get; }
    }
}