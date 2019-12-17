namespace compiler.CodeAnalysis.Text
{
    public sealed class TextLine
    {
        

        public TextLine(SourceText text , int start , int lenght , int lenghtIncludingLineBreak)
        {
            Text = text;
            Start = start;
            Lenght = lenght;
            LenghtIncludingLineBreak = lenghtIncludingLineBreak;
        }

        public SourceText Text { get; }
        public int Start { get; }
        public int Lenght { get; }
        public int End => Start + Lenght;
        public int LenghtIncludingLineBreak { get; }

        public TextSpan Span => new TextSpan(Start , Lenght);
        public TextSpan SpanIncludingLineBreak => new TextSpan(Start, LenghtIncludingLineBreak);

        public string Tostring() => Text.ToString(Span);
    }
}