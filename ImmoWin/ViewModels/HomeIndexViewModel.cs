using ImmoWin.DAL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImmoWin.ViewModels
{
    public class HomeIndexViewModel
    {

        public List<Building> Buildings { get; set; }

      
        public List<SelectListItem> SelectValues { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Appartement", Text = "Appartement", Selected = false },
            new SelectListItem { Value = "Huis", Text = "Huis", Selected = false  },
        };
        

}
}
