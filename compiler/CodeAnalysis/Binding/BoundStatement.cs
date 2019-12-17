﻿namespace compiler.CodeAnalysis.Binding
{
    internal abstract class BoundStatement: BoundNode
    {

    }

    internal sealed class BoundIfStatement:BoundStatement
    {
        public BoundIfStatement (BoundExpression condition , BoundStatement thenStatement , BoundStatement elseStatement)
        {
            Condition = condition;
            ThenStatement = thenStatement;
            ElseStatement = elseStatement;
        }


        public override BoundNodeKind Kind => BoundNodeKind.IfStatement;
        public BoundExpression Condition { get; }
        public BoundStatement ThenStatement { get; }
        public BoundStatement ElseStatement { get; }

    }
}