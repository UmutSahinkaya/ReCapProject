﻿using System;
using System.Collections.Generic;
using System.Text;
using Entitiy.Abstract;

namespace Entitiy.Concrete
{
    public class Color:IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}