using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passgen
{
    class Password
    {

        public bool HasUpperCase { get; set; }
        public bool HasNumbers { get; set; }
        public bool HasSpecialKeys { get; set; }
        public int Length { get; set; }


        public Password(bool hasUpperCase, bool hasNumbers, bool hasSpecialKeys, int length)
        {
            HasUpperCase = hasUpperCase;
            HasNumbers = hasNumbers;
            HasSpecialKeys = hasSpecialKeys;
            Length = length;
        }

    }
 }