using System.Collections.Generic;

namespace compiler.CodeAnalysis.Syntax
{
    public sealed class ParenthesizedExpressionSyntax : ExpressionSyntax
    {
        public ParenthesizedExpressionSyntax(SyntaxToken OpenParenthesisToken, ExpressionSyntax expression, SyntaxToken CloseParenthesisToken)
        {
            this.OpenParenthesisToken = OpenParenthesisToken;
            Expression = expression;
            this.CloseParenthesisToken = CloseParenthesisToken;
        }

        public override SyntaxKind Kind => SyntaxKind.ParenthesizedExpression;

        public SyntaxToken OpenParenthesisToken { get; }
        public ExpressionSyntax Expression { get; }
        public SyntaxToken CloseParenthesisToken { get; }

       
    }


}