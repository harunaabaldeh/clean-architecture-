﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domian
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public Decimal Cost { get; set; }
    }
}
