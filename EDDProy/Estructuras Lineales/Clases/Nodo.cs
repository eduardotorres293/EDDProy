﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    // Nodo utilizado en pilas, colas, y listas simples y circulares simples
    public class Nodo
    {
        public string Valor;
        public Nodo sig;

        public Nodo(string valor)
        {
            Valor = valor;
            sig = null;
        }
    }
}
