using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Criando uma composição de endereço para que fique mais completo!

namespace Sistema_UC12.Classes
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public bool enderecoComercial { get; set; }

    }
}