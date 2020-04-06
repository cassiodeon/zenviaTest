using Business;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nota> notasCaixa = new List<Nota>
            {
                new Nota(100),
                new Nota(50),
                new Nota(20),
                new Nota(10)
            };
            CaixaEletronico caixaEletronico = new CaixaEletronico(notasCaixa);

            Console.WriteLine("Caixa Eletrônico com notas de 100, 50, 20 e 10");
            Console.WriteLine("Realizar saque de R$ 80");
            Console.WriteLine("Notas Sacadas: ");
            List<Nota> notasSacadas = caixaEletronico.Sacar(80);
            foreach (Nota nota in notasSacadas)
            {
                Console.WriteLine("\t R$ "+nota.valor);
            }

            Console.WriteLine("Realizar saque de R$ 130");
            Console.WriteLine("Notas Sacadas: ");
            notasSacadas = caixaEletronico.Sacar(130);
            foreach (Nota nota in notasSacadas)
            {
                Console.WriteLine("\t R$ " + nota.valor);
            }
        }
    }
}
