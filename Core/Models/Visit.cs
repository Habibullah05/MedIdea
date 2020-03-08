using System;

namespace Core.Models
{
    public class Visit
    {
        public Guid Id { get; set; }
        public ClientCart Client { get; set; }
        public DateTime DateOfVisit { get; set; }
        public TypeVisit TypeVisit { get; set; }
        public string Diagnosis { get; set; }
        

    }

}
