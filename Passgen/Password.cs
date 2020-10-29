using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passgen
{
    class Password
    {

        public bool HasUpperCase { get => HasUpperCase; set => HasUpperCase = value; }
        private bool HasNumbers { get; set; }
        private bool HasSpecialNumbers { get; set; }
        private string MasterWord { get; set; }
        private int Length { get; set; }


        public Password(bool hasUpperCase, bool hasNumbers, bool hasSpecialNumbers, string masterWord, int length)
        {
            HasUpperCase = hasUpperCase;
            HasNumbers = hasNumbers;
            HasSpecialNumbers = hasSpecialNumbers;
            MasterWord = masterWord;
            Length = length;
        }

    }
 }