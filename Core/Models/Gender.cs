using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<ClientCart> ClientCarts { get; set; }

    }
}
