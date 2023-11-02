using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardDate { get; set; }
        public string CreditCardCvv { get; set; }
        public int CarId { get; set; }
        public int RentalId { get; set; }
        public int Price { get; set; }

    }
}
