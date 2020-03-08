using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class ClientCart
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<Visit> Visits { get; set; }



    }

  
}
