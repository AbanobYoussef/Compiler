using compiler.CodeAnalysis.Symbols;
using System;

namespace compiler.CodeAnalysis.Binding
{
    internal abstract class BoundExpression : BoundNode
    {
        public abstract TypeSymbol Type { get; }
    }
}