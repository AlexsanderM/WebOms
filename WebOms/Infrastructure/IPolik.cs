using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDomain.Model;

namespace WebOms.Infrastructure
{
    public interface IPolik
    {
        IEnumerable<MedService> GetSections();
    }
}
