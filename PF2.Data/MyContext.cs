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
                    Name = "Guitarras"
                }
            };
        }
    }
}
