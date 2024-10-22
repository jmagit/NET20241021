﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades {
    public class Persona {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public override string ToString() {
            return $"Id: {Id}, Nombre: {Nombre}, Apellidos: {Apellidos}";
        }

    }
}
