using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BrandDetailDto :IDto
    {
        public string BrandId { get; set; }
        public string BrandName { get; set; }
       


        public override string ToString()
        {
            return BrandId + " " + BrandName;
        }
    }
}
