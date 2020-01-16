using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Error : Name field is empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Error : Email field is empty")]
        [RegularExpression(".+\\@.+\\..+",
                ErrorMessage = "Error : Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Error : Phone number field is empty")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Error : RSVP answer not entered")]
        public bool? WillAttend { get; set; }
    }
}