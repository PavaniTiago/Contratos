using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.entidades
{
    class ContratoCLT : Contrato
    {
        public int Cpf { get; set; }
        public int Idade { get; set; }

        public ContratoCLT()
        { }

        public ContratoCLT(int cpf, int idade, int numero, string contratante, int prazo, double valor)
            : base(numero, contratante, prazo, valor)
        {
            Cpf = cpf;
            Idade = idade;
        }

        public override double CalcularPrestacao()
        {
            if (Idade <= 30)
            {
                return base.CalcularPrestacao() + 1;
            }
            else if (Idade >= 30 && Idade <= 40)
            {
                return base.CalcularPrestacao() + 2;
            }
            else if (Idade >= 40 && Idade < 50)
            {
                return base.CalcularPrestacao() + 3;
            }
            else
            {
                return base.CalcularPrestacao() + 4;
            }
        }

            public override string ExibirInfo()
        {
            return "Número do Contratante: "
                + Numero
                + "Nome Contratante: "
                + Contratante
                + "Prazo do Contrato"
                + Prazo
                + "Valor do Contrato"
                + Valor
                + "Cpf: "
                + Cpf
                + "Idade: "
                + Idade
                + "Cálculo da Prestação: "
                + CalcularPrestacao();
        }
    }
    }

