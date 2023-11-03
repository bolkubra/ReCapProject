using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental :IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? RentStartDate { get; set; } = null;
        public DateTime? RentEndDate { get; set; } = null;
        public DateTime? ReturnDate { get; set; } = null;
    }
}
