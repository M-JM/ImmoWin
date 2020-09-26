using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ImmoWin.DAL.Models
{
    public class Building
    {
        [Key]
        public int BuildingId { get; set; }
        public int Price { get; set; }
      
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        [ForeignKey("BuildingType")]
        public int BuildingTypeId { get; set; }
        public virtual BuildingType BuildingType { get; set; }

    }
}
