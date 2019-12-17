using System.Collections.Generic;
using compiler.CodeAnalysis.Text;

namespace compiler
{
    internal class TextSpanComparer : IComparer<TextSpan>
    {
        public int Compare(TextSpan x, TextSpan y)
        {
            int cmp = x.Start - y.Start;
            if (cmp == 0)
                cmp = x.Length - y.Length;
            return cmp;
        }
    }
}