using ImmoWin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImmoWin.DAL.Repositories
{
    public interface IHomeRepository
    {
        List<Building> GetBuildings();
        List<Building> GetSelectedBuildings(List<string> Searchterms);
    };
}
