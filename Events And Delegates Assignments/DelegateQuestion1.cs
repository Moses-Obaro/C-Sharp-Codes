using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsAssignments
{
    /// <summary>
    /// This Class Contains properties for User Identification
    /// Properties include LastName, FirstName, UserName
    /// The UserName is a concatenation of the FirstName, a period(.) and the Last Name 
    /// </summary>
    public class Users
    {
        /// <summary>
        /// a Predicate to check if username is equal to likelyUsername.
        /// A delegate that returms a boolean value is a predicate
        /// </summary>
        /// <param name="n"></param>
        public delegate bool DUserCount(Users n);


        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string UserName { get; set; }


        /// <summary>
        /// This method returns the Likely username of a user.
        /// This is a concatenation of FirstName, a period(.) and LastName
        /// </summary>
        public string LikelyUserName()
        {
            var value = FirstName + "." + LastName;
            return value;
        }
    }
}