using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class CaixaEletronico
    {
        public List<Nota> notas { get; set; }

        public CaixaEletronico(List<Nota> notas)
        {
            this.notas = notas;
        }

        public List<Nota> Sacar(int valor)
        {
            if(valor == 0)
                throw new Exception("Valor inválido.");

            List<Nota> notasSaque = new List<Nota>();
            this.notas.Sort((x, y) => y.valor.CompareTo(x.valor));
            foreach (Nota notaCaixa in notas)
            {
                int qtdNotas = Math.DivRem(valor, notaCaixa.valor, out valor);
                for (int i = 0; i < qtdNotas; i++)
                {
                    notasSaque.Add(notaCaixa);
                }
            }

            if (valor > 0)
                throw new Exception("Não foi possível sacar o valor desejado.");

            return notasSaque;
        }
    }
}
