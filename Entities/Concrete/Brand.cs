using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : BaseEntity, IEntity 
    {
       
        public string BrandName { get; set; }
    }
}
