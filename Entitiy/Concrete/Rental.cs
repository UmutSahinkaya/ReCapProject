using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entitiy.Concrete
{
    public class Rental:IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }


    }
}
