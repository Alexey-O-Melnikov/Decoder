using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder
{
    public class Letter : IComparable
    {
        public char Symbol { get; set; }
        public double Chastota { get; set; }
        public int CountInText { get; set; }
        public Letter(char symbol, double chastota)
        {
            Symbol = symbol;
            Chastota = chastota;
        }
        public Letter(char symbol, int countInText)
        {
            Symbol = symbol;
            CountInText = countInText;
        }

        public int CompareTo(object obj)
        {
            return Chastota.CompareTo(obj);
        }
    }

}
