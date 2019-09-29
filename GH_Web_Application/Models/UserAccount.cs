using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GH_Web_Application.Models
{
    public class UserAccount
    {
        [Key]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Name is missing.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone Number is missing.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email address is missing.")]
        public string EmailAddress { get; set; }

        public int? Rating { get; set; }

        [Required(ErrorMessage = ("Password is missing."))]
        public string Password { get; set; }

        //Constructor
        public UserAccount()
        { }
        public UserAccount(DataRow row)
        {
            UserId = row["USERID"].ToString();
            Name = row["NAME"].ToString();
            PhoneNumber = row["PHONENUMBER"].ToString();
            EmailAddress = row["EMAILADDRESS"].ToString();
            //Rating = Convert.ToInt32(row["RATING"]);
            Password = row["PASSWORD"].ToString();
        }

    }
}
