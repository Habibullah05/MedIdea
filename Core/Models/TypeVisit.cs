using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class TypeVisit
    {
        public int Id { get; set; }
        public string Title  { get; set; }

        public IEnumerable<Visit> Visits { get; set; }


    }
}
