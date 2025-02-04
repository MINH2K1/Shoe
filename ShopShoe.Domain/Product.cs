﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopShoe.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; }
        public bool Homeflag { get; set; }
        public bool Hotflag { get; set; }
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
