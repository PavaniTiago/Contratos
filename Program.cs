using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp6.entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> lista = new List<Contrato>();

            Console.WriteLine("Quantos contratos irá ser cadastrados?");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i <= n; i++)
            {
                Console.WriteLine("Pessoa Física ou Jurídica ( F / J ): ");
                char choice = char.Parse(Console.ReadLine());
                if (choice == 'F' || choice == 'f')
                {
                    Console.Write("Número Contrato: ");
                    int Numero = int.Parse(Console.ReadLine());
                    Console.Write("Nome do Contratante: ");
                    string Contratante = Console.ReadLine();
                    Console.Write("Prazo em meses: ");
                    int Prazo = int.Parse(Console.ReadLine());
                    Console.Write("Valor do Contrato: ");
                    double Valor = double.Parse(Console.ReadLine());
                    Console.Write("CPF: ");
                    int Cpf = int.Parse(Console.ReadLine());
                    Console.Write("Idade: ");
                    int Idade = int.Parse(Console.ReadLine());
                    lista.Add(new ContratoCLT(Numero, Contratante, Prazo, Valor, Cpf, Idade));
                }
                else if (choice == 'J' || choice == 'j')
                {
                    Console.Write("Número Contrato: ");
                    int Numero = int.Parse(Console.ReadLine());
                    Console.Write("Nome do Contratante: ");
                    string Contratante = Console.ReadLine();
                    Console.Write("Prazo em meses: ");
                    int Prazo = int.Parse(Console.ReadLine());
                    Console.Write("Valor do Contrato: ");
                    double Valor = double.Parse(Console.ReadLine());
                    Console.Write("CNPJ: ");
                    int Cnpj = int.Parse(Console.ReadLine());
                    Console.Write("Inscrição Estadual: ");
                    string InscricaoEstadualContratante = Console.ReadLine();
                    lista.Add(new ContratoPJ(Numero, Contratante, Prazo, Valor, Cnpj, InscricaoEstadualContratante));
                }

                foreach (Contrato c in lista)
                {
                    Console.WriteLine();
                    Console.WriteLine("Dados: ");
                    Console.WriteLine();
                    Console.WriteLine(c.ExibirInfo());
                }
            }
            }
        }
    }

