using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebDomain.Model;

namespace WebOms.DAL.Context
{
    public class WebOmsContext : DbContext
    {
        public WebOmsContext(DbContextOptions options) : base(options)
        { }

        public DbSet<MedService> MedServices { get; set; }
    }
}
