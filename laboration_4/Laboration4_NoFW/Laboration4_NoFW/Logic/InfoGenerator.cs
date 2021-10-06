using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laboration4_NoFW.Logic
{
    public class InfoGenerator
    {
        public string UsernameGenerator(string firstName, string lastName)
        {
            try
            {
                string username = $"{firstName.Substring(0, 1).ToLower()}{lastName}{DateTime.Now.Year}";
                return username;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return ex.ToString();
            }
        }
    }
}
