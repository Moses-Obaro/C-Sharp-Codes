using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_INEC_APP
{
    /// <summary>
    /// This interface has a list of properties that every voter should have
    /// The voterDataBase may decide to add if the voter is a political candidate
    /// </summary>
    internal interface IHumanModel
    {
        public static string FirstName {get; set; }
        public static string LastName {get; set; }
        public static string FullName { get; set; }
        public static bool IsPoliticalCandidate { get; set; } = false;

        public abstract string GetFirstName();
        public abstract string GetLastName();
        public abstract string GetFullName();
    }

    
}
