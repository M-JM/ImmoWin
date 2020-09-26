using ImmoWin.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImmoWin.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuildingType>().HasData(

                new BuildingType()
                {
                    BuildingTypeId = 1,
                    Name = "Appartement",
                    Type = "Studio"
                },
                new BuildingType()
                {
                    BuildingTypeId = 2,
                    Name = "Huis",
                    Type = "Rijhuis"
                },
                new BuildingType()
                {
                   BuildingTypeId = 3,
                   Name = "Huis",
                    Type = "Alleenstaand Huis"
                },
                new BuildingType()
                {
                    BuildingTypeId = 4,
                    Name = "Huis",
                    Type = "Villa"
                },
                new BuildingType()
                {
                    BuildingTypeId = 5,
                    Name = "Appartement",
                    Type = "Loft"
                  }


                );

            modelBuilder.Entity<Address>().HasData(

               new Address()
               {
                   AddressId = 1,
                   Street = "NeerStraat",
                   HouseNumber = 12,
                   City = "Genk",
                   Zipcode = 3000,
                   Floor = null,
                   Country = "Belgium"


               },
               new Address()
               {
                   AddressId = 2,
                   Street = "ZijStraat",
                   HouseNumber = 32,
                   City = "Antwerpen",
                   Zipcode = 4510,
                   Floor = null,
                   Country = "Belgium"
               },
               new Address()
               {
                   AddressId = 3,
                   Street = "OpStraat",
                   HouseNumber = 5,
                   City = "Mechelen",
                   Zipcode = 2000,
                   Floor = 1,
                   Country = "Belgium"
               },
               new Address()
               {
                   AddressId = 4,
                   Street = "OpStraat",
                   HouseNumber = 5,
                   City = "Mechelen",
                   Zipcode = 2000,
                   Floor = 2,
                   Country = "Belgium"
               }

               );

            modelBuilder.Entity<Building>().HasData(

               new Building()
               {
                   BuildingId = 1,
                   AddressId = 1,
                   BuildingTypeId = 2,
                   Price = 100000
               },
               new Building()
               {
                   BuildingId = 2,
                   AddressId = 2,
                   BuildingTypeId = 3,
                   Price = 756000
               },
               new Building()
               {
                   BuildingId = 3,
                   AddressId = 3,
                   BuildingTypeId = 5,
                   Price = 500000
               },
               new Building()
               {
                   BuildingId = 4,
                   AddressId = 4,
                   BuildingTypeId = 1,
                   Price = 250000
               }

               ) ;
        }
    }
}
