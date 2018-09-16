using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDomain.Model;
using WebOms.DAL.Context;

namespace WebOms.Infrastructure.Sql
{
    public class SqlPolik : IPolik
    {
        private readonly WebOmsContext _context;

        public SqlPolik(WebOmsContext context)
        {
            _context = context;
        }

        public IEnumerable<MedService> GetSections()
        {
            return _context.MedServices.AsQueryable().ToList();

        }
    }
}
