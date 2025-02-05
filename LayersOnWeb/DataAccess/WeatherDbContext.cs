﻿using DataAccess.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class WeatherDbContext : IdentityDbContext<IdentityUser>
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
       : base(options)
        {
        }
        public DbSet<WeatherForecastEntity> WeatherEntities { get; set; }
        public DbSet<ShowEntity> ShowEntities { get; set; }

        public DbSet<TicketEntity> TicketEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.;Database=dbweather;Trusted_Connection=True;");
        }
    }
}
