using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guessing_Game
{
    public class CharVariables
    {
        private char gW1;
        private char gW2;
        private char gW3;
        private char gW4;
        private char gW5;

        private char wW1;
        private char wW2;
        private char wW3;
        private char wW4;
        private char wW5;

        private int situation;

        public char GW1 { get => gW1; set => gW1 = value; }
        public char GW2 { get => gW2; set => gW2 = value; }
        public char GW3 { get => gW3; set => gW3 = value; }
        public char GW4 { get => gW4; set => gW4 = value; }
        public char GW5 { get => gW5; set => gW5 = value; }
        public char WW1 { get => wW1; set => wW1 = value; }
        public char WW2 { get => wW2; set => wW2 = value; }
        public char WW3 { get => wW3; set => wW3 = value; }
        public char WW4 { get => wW4; set => wW4 = value; }
        public char WW5 { get => wW5; set => wW5 = value; }
        public int Situation { get => situation; set => situation = value; }
        
    }
}