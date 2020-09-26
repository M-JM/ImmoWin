using ImmoWin.DAL.Context;
using ImmoWin.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImmoWin.DAL.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly AppDbContext _context;

        public HomeRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Building> GetBuildings()
        {
            List<Building> buildings = _context.Buildings
                .Include(x => x.Address)
                .Include(x => x.BuildingType)
                .ToList();

            return buildings;
        }

        public List<Building> GetSelectedBuildings(List<string> Searchterms)
        {
            var result = _context.Buildings
                 .Include(x => x.Address)
                 .Include(x => x.BuildingType).AsQueryable();

            if (Searchterms != null && Searchterms.Count > 0)
            {
                result = result.Where(x => Searchterms.Contains(x.BuildingType.Name.ToLower()));
            } 
            return result.ToList();
        }

    }
}
