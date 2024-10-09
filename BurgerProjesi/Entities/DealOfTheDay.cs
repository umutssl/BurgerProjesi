﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerProjesi.Entities
{
    public class DealOfTheDay
    {
        public int DealOfTheDayID{ get; set; }
        public string Titel{ get; set; }
        public string Description{ get; set; }
        public decimal Price{ get; set; }
        public string ImageUrl{ get; set; }
        public bool Status{ get; set; }
    }
}