using System;
using System.Collections.Generic;
using System.Text;

namespace WebDomain.Model.Base
{
    public class ServiceEntity : BaseEntity, IServiceEntity
    {
        public int Service { get; set; }
    }
}
