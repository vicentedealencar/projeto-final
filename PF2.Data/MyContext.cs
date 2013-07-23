using PF2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF2.Data
{
    public class MyContext
    {
        public List<Store> Stores { get; set; }

        public MyContext()
        {
            Stores = new List<Store>() 
            {
                new Store()
                {
                    Id = 1,
                    Name = "Guitarras",
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Id = 1,
                            Price = 100.05,
                            Title = "Les Paul",
                            SubTitle = "Best guittar ever",
                            Description = "You must buy that!"
                        },
                        new Item()
                        {
                            Id = 2,
                            Price = 200.05,
                            Title = "Flying V",
                            SubTitle = "Rock it out!",
                            Description = "Classic Gibson model"
                        }
                    }
                }
            };
        }
    }
}
