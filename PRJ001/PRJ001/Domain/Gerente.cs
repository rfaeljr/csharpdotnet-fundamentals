using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Gerente : Pessoa
    {
        public string Cargo { get; set; }
        public override float getRiscoSaude(int idade)
        {
            if (this.Cargo == "Gerente Senior")
            {
                return (idade * (2 ^ 3));
            }

            if( this.Cargo == "Gerente" )
            {
                return idade * idade;
            }
            return 0.99f * 77f;
        }
    }
}
