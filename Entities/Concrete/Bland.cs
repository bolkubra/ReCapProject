using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bland : IEntity
    {
        public int BlandId { get; set; }
        public string BlandName { get; set; }
    }
}
