using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public string Conta { get; set; }
        public int NumeroAgencia { get; set; }
        public string NomeAgencia { get; set; }
        public double Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public static int TotalContas { get; set; }

        public ContaCorrente()
        {
            TotalContas++;
        }

        public ContaCorrente(ContaCorrente contaCorrente)
        {
            this.Titular = contaCorrente.Titular;
            this.Conta = contaCorrente.Conta;
            this.NumeroAgencia = contaCorrente.NumeroAgencia;
            this.NomeAgencia = contaCorrente.NomeAgencia;
            this.Saldo = contaCorrente.Saldo;
            this.Cliente = contaCorrente.Cliente;
            TotalContas++;
        }

        public void printAll()
        {
            Console.WriteLine("**** Dados de Conta Corrente ****");
            Console.WriteLine("Titular: "+this.Titular);
            Console.WriteLine("Conta: " + this.Conta);
            Console.WriteLine("Número Agência: " + this.NumeroAgencia);
            Console.WriteLine("Nome Agência: " + this.NomeAgencia);
            Console.WriteLine("Saldo: " + this.Saldo);
            Console.WriteLine("Total de Contas Correntes: " + TotalContas);
        }
    }
}
