using System;
using System.Collections.Generic;
using System.Text;

namespace ImmoWin.DAL.Models
{
    public class BuildingType
    {
        public int BuildingTypeId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List <Building> Buildings { get; set; }
    }
}
