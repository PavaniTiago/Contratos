using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.entidades
{
    class ContratoPJ : Contrato
    {
        public int Cnpj{ get; set; }
        public string InscriçãoEstadualContratante{ get; set; }

        public ContratoPJ()
        { }

        public ContratoPJ(int numero, string contratante, int prazo, double valor, int cnpj, string inscricaoEstadualContratante)
            : base(numero, contratante, prazo, valor)
        {
            Cnpj = cnpj;
            InscriçãoEstadualContratante = inscricaoEstadualContratante;
        }

        public override double CalcularPrestacao()
        {
            return base.CalcularPrestacao() + 3;
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
                + "CNPJ: "
                + Cnpj
                + "Inscriçaõ Estadual do Contratante: "
                + InscriçãoEstadualContratante
                + "Cálculo da Prestação: "
                + CalcularPrestacao();
        }
    }
}
