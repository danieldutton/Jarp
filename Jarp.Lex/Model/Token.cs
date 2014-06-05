namespace Jarp.Lex.Model
{
    public class Token
    {
        public TokenPosition Position { get; set; }
        
        public string Type { get; set; }
        
        public string Value { get; set; }

        
        public Token(string type, string value, TokenPosition position)
        {
            Type = type;
            Value = value;
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("Token: {{ Type: \"{0}\", Value: \"{1}\", Position: {{ Index: \"{2}\", Line: \"{3}\", Column: \"{4}\" }} }}"
                , Type, Value, Position.Index, Position.Line, Position.Column);
        }
    }
}
