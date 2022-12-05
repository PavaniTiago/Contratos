using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public int Prazo{ get; set; }
        public double Valor{ get; set; }

        public Contrato()
        { }

        public Contrato(int numero, string contratante, int prazo, double valor)
        {
            Numero = numero;
            Contratante = contratante;
            Prazo = prazo;
            Valor = valor;
        }

        public virtual double CalcularPrestacao()
        {
           double ValorPrestacao = Valor / Prazo;
            return ValorPrestacao;
        }

        public virtual string ExibirInfo()
        {
            return "Número do Contratante: "
                + Numero
                + "Nome Contratante: "
                + Contratante
                + "Prazo do Contrato"
                + Prazo
                + "Valor do Contrato"
                + Valor;
        }
    }
}
