﻿using api.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{ 
    public class DBcontext : IdentityDbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options)
        {
        }
        public DbSet<ApplicationUser> Users {  get; set; }
    }
}
