using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public PlayerModel()
        {

        }

        public PlayerModel(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }
    }
}
