using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : BaseEntity, IEntity
    {
      
        public string ColorName { get; set; }
    }
}
