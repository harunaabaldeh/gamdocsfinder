using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Document
    {
        public Guid Id { get; set; }
        public string DocumentName { get; set; }
        public string FounderFullName { get; set; }
        public string FounderPhoneNumber { get; set; }
        public string FounderAddress { get; set; }
        public string OwnerFullName { get; set; }
        public string DocumentNumber { get; set; }
        public string PlaceFound { get; set; }
        public DateTime DateFound { get; set; }
        public string Image { get; set; }
        // this field will come from the user.
        // public string FoundedBy { get; set; } 
    }
}