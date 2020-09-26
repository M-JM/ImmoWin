using ImmoWin.DAL.Models;
using ImmoWin.DAL.Repositories;
using ImmoWin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace ImmoWin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;

        public HomeController(IHomeRepository homeRepository) 
        {
            _homeRepository = homeRepository;
        }


        [HttpGet]
        public ViewResult Index()
        {
           
                List<Building> buildings = _homeRepository.GetBuildings();

                HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel()
                {
                    Buildings = buildings
                };

                return View(homeIndexViewModel);
                      
        }

        [HttpPost]
        public IActionResult Index(HomeIndexViewModel indexViewModel)
        {
            List<string> Searchterms = new List<string>();

            foreach (var item in indexViewModel.SelectValues)
            {
                if (item.Selected)
                {
                    Searchterms.Add(item.Value.ToLower());
                }
            };

            List<Building> buildings = _homeRepository.GetSelectedBuildings(Searchterms);

            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel()
            {
                Buildings = buildings,
                SelectValues = indexViewModel.SelectValues,
                
            };
            return View(homeIndexViewModel);

        }


    }
}
