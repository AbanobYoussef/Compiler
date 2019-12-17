using compiler.CodeAnalysis.Symbols;
using System;

namespace compiler.CodeAnalysis.Binding
{
    internal sealed class BoundAssigmentExpression : BoundExpression
    {
        

        public BoundAssigmentExpression(VariableSymbol variable, BoundExpression expression)
        {
            Variable = variable;
            Expression = expression;
        }

        public override TypeSymbol Type => Expression.Type;

        public override BoundNodeKind Kind => BoundNodeKind.AssigmentExpression;
        public VariableSymbol Variable { get; }
        public BoundExpression Expression { get; }
    }
}