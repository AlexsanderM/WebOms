using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDomain.Model;
using WebOms.DAL.Context;

namespace WebOms.Data
{
    public static class DbInitialize
    {
        public static void Initialize(WebOmsContext context)
        {
            context.Database.EnsureCreated();
            // Look for any products.
            if (context.MedServices.Any())
            {
                return;
            }
            var sections = new List<MedService>()
            {
                new MedService()
                {
                    Id = 2,
                    Service = 2001
                }
            };
        }
    }
}
