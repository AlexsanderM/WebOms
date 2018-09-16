using System;
using System.Collections.Generic;
using System.Text;

namespace WebDomain.Model.Base
{
    public interface IServiceEntity : IBaseEntity
    {
        int Service { get; set; }
    }
}
