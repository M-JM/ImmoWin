using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImmoWin.DAL.Models
{
   public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int? Floor { get; set; }

        public string City { get; set; }

        public int Zipcode { get; set; }

        public string Country { get; set; }

        public List<Building> Buildings { get; set; }


    }
}
