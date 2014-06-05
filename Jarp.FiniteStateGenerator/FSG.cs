using System;
using System.Collections.Generic;
using ProjectX.FiniteStateGenerator;
using ProjectX.Lex.Model;

namespace Jarp.FiniteStateGenerator
{
    public class FSG
    {
        private readonly List<Terminal<string>> _terminalList = new List<Terminal<string>>();

        public List<Terminal<string>> TerminalList { get; set; }

        public int TerminalCount { get; set; }

        public string Identifier { get; set; }

        private int _currentState = 0;

        private List<Token> _undoQueue1;

        private List<Token> _undoQueue2;


        public FSG(string identifier)
        {
            _undoQueue1 = new List<Token>();
            _undoQueue2 = new List<Token>();
            Identifier = identifier;
        }


        public void AddTerminal(Terminal<string> terminal)
        {
            _terminalList.Add(terminal);
        }


        public void ListTerminals()
        {
            foreach (Terminal<string> t in TerminalList)
            {
                Console.WriteLine(@"Terminal: " + t.Input + "\\" + t.Output);
            }
        }

        /*
        public List<Token> InputToken(List<Token> tokenList)
        {
            int i;

            for (i=0; i < tokenList.Count; i++)
            {
                Token token = tokenList[i];
                Token origToken = (Token)tokenList[i].Clone();

                string sourceLexeme = token.Lexeme;
                string targetLexeme = TerminalList[_currentState].Input;

                if (sourceLexeme.Equals(targetLexeme))
                {
                    token.Lexeme = TerminalList[_currentState].Output;
                    _currentState += 1;

                    if (token.Scanned == false)
                    {
                        _undoQueue1.Add(origToken);
                        _undoQueue2.Add(token);
                    }

                    token.Scanned = true;

                    Console.WriteLine("Move to state " + _currentState);

                }
                else
                {
                    resetDFA();

                    for (int j = 0; j < _undoQueue2.Count; j++)
                    {
                        if (_undoQueue1.Count == 0)
                        {
                            //Token t = _undoQueue1.
                        }
                    }
                }
            }
        }
        */

        private void resetDFA()
        {
            _currentState = 0;
        }


        private void NulLCheck(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(obj.GetType().ToString());
        }


        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
