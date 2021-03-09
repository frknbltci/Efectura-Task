using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string SingleID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public DateTime LastModified { get; set; }
        public DateTime CreationDate { get; set; }

       
    }
}
