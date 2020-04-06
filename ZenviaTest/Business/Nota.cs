using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Nota
    {
        public int valor { get; set; }

        public Nota(int valor)
        {
            this.valor = valor;
        }

        // override object.Equals
        public override bool Equals(object nota)
        {
            return this.valor == ((Nota)nota).valor ;
        }

    }
}
