using compiler.CodeAnalysis.Symbols;
using System;

namespace compiler.CodeAnalysis.Binding
{
    internal sealed class BoundVariableExpression : BoundExpression
    {
        public BoundVariableExpression (VariableSymbol variable)
        {
            Variable = variable;
        }

        public override BoundNodeKind Kind => BoundNodeKind.VariableExpression;

        public override TypeSymbol Type => Variable.Type;


        public VariableSymbol Variable { get; }
    }
}