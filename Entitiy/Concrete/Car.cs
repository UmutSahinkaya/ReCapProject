using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entitiy.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
} //bütün prop ların tabloda ki kolon adları ile aynı olmak zorunda, prop u değiştirmekdense, vt de colomn adını deiştir propda ki yap
// eğer illaha da propda ki olmasın vtlerde sneak_case yaygın böyle istiyorumda dersen...
// şu açtıgım video da eşleştirme yapar. eğer hala sorun yaparsa başka birseydendir
// ha bi de hatayı okuman gerek bak şimdi
