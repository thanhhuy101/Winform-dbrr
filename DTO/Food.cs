﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Des { get; set; }
        public int Price { get; set; }
        public string Img { get; set; }

        public Food() { }
    }
}
