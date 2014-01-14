namespace ProjectX.Lex.Model
{
    public class TokenPosition
    {
        public int Column { get; private set; }
        
        public int Index { get; private set; }
        
        public int Line { get; private set; }

        
        public TokenPosition(int index, int line, int column)
        {
            Index = index;
            Line = line;
            Column = column;
        }

        public override string ToString()
        {
            return string.Format("[{0}] Column: {1} Index: {2} Line: {3}", 
                GetType().Name, Column, Index, Line);
        }
    }
}
