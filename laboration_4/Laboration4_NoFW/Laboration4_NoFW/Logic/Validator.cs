using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4_NoFW.Logic
{
    public class Validator
    {
        public bool ValidateField(string fieldName)
        {
            bool output = true;
            char[] invalidCharacters = "`~!#$%^&*()_+=0123456789<>,?/\\|{}[]'\"".ToCharArray();

            if (fieldName.Length < 2)
            {
                output = false;
            }

            if (fieldName.IndexOfAny(invalidCharacters) >= 0)
            {
                output = false;
            }

            return output;
        }
    }
}
