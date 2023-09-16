using System;

namespace DAL.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
