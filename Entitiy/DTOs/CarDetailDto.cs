using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entitiy.DTOs
{
    public class CarDetailDto:IDto
    {
        public int  Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
    }
}
