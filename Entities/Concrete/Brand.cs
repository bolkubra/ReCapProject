using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int BlandId { get; set; }
        public string BlandName { get; set; }
    }
}
