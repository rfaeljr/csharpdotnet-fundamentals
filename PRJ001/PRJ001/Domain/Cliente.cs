using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public DateTime dataNascimento { get; set; }

        public void printAll() {
            Console.WriteLine();
            Console.WriteLine("**** Dados do Cliente ****");
            Console.WriteLine("Identificador: "+this.Id);
            Console.WriteLine("Documento: " + this.Documento);
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Endereço: " + this.Endereco);
            Console.WriteLine("Data de Nascimento: "+dataNascimento.ToString("dd/MM/yyyy"));
        }
    }
}
