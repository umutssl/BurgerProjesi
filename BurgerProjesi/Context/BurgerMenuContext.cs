using BurgerProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BurgerProjesi.Context
{
    public class BurgerMenuContext : DbContext
    {
        public DbSet<Category> Categories {  get; set; }
        public DbSet<DealOfTheDay>DealOfTheDays {  get; set; }
        public DbSet<Product>Products {  get; set; }
        public DbSet<Testimonial>Testimonials {  get; set; }
        public DbSet<Admin1>Admin1s {  get; set; }
    }
}