using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class StringUtilits
    {
        public string Str { get; set; }

        public StringUtilits(string input) //метод, принимающий введенную строку
        {
            Str = input;
        }

        public bool ABCloseToEachOther(char a, char b)
        {
            for(int i=0; i<Str.Length-1; i++)
            {
              if (Str[i]==a && Str[i + 1]==b || Str[i] == b && Str[i + 1]==a) return true ;     
            }

            return false;
        }
    }
    
}
