﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLoAprendido
{
    public abstract class clsAbsPersonas
    {
        public abstract string Nombre { get; set; }
        public abstract string Apellido { get; set; }
        public abstract int Edad { get; set; }
        public abstract Int64 Dni { get; set; }

    }
}
