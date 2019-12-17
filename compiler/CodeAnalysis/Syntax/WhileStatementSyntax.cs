namespace compiler.CodeAnalysis.Syntax
{
    internal sealed class WhileStatementSyntax: StatementSyntax
    {
        public WhileStatementSyntax (SyntaxToken whileToken , ExpressionSyntax condition , StatementSyntax body)
        {
            WhileToken = whileToken;
            Condition = condition;
            Body = body;
        }

        public override SyntaxKind Kind => SyntaxKind.WhileStatement;
        public SyntaxToken WhileToken { get; }
        public ExpressionSyntax Condition { get; }
        public StatementSyntax Body { get; }

    }
}