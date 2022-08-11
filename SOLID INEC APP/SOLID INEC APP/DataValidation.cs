using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_INEC_APP
{
    internal class DataValidation
    {
        public static string ValidateData(string name)
        {
            bool isValid = false;
            
            try
            {
                
                while ((Char.IsDigit(name[0])) &&  (name == null) && (Char.IsSymbol(name[0])) )
                {
                    name = Console.ReadLine();
                }
                    
               
            }
            catch (ArgumentNullException nullValue)
            {
                Console.WriteLine("You have entered an empty value");
            }
            return name;            
            
        }
    }
}

