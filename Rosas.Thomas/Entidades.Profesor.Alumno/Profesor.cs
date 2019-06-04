﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Humanos
{
    public class Profesor : Persona
    {
        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " - Titulo: " + this.Titulo; 
        }
    }
}
