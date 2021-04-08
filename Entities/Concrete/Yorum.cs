﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Yorum :IEntity
    {
        public int uyeNo { get; set; }
        public int baslikNo { get; set; }
        public DateTime yorumTar { get; set; }
        public string yorum { get; set; }
    }
}
