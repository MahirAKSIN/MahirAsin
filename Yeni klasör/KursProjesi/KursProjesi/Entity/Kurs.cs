﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProjesi.Entity
{
    class Kurs
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Sorumlu { get; set; }
        public DateTime BaslangicT { get; set; }
        public int Sure { get; set; }
    }
}
