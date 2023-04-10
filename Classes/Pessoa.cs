using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC12.Classes
{
    public abstract class Pessoa
    {
        public string? Nome {get; set;} //? Para deixar o objeto nullable
        public string? Endereco { get; set; } //Atalho prop + Enter
        public bool? Endereco_Comercial { get; set; }

        public void PagarImposto () {}
    }
}