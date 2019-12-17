using System.Collections.Immutable;

namespace compiler.CodeAnalysis.Syntax
{
    public sealed class BlockStatementSyntax :StatementSyntax
    {
        public BlockStatementSyntax(SyntaxNode openBraceToken , ImmutableArray<StatementSyntax> statements , SyntaxToken closeBraceToken)
        {
            OpenBraceToken = openBraceToken;
            Statements = statements;
            CloseBraceToken = closeBraceToken;
        }


        public override SyntaxKind Kind => SyntaxKind.BlockStatement;

        public SyntaxNode OpenBraceToken { get; }
        public ImmutableArray<StatementSyntax> Statements { get; }
        public SyntaxToken CloseBraceToken { get; }

    }
}