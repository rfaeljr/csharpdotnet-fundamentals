using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string documento { get; set; }


        public virtual float getRiscoSaude(int idade) {
            return idade * 0.99f;
        }
    }
}
