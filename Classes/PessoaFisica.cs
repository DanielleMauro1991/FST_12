using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC12.Classes

{

public class PessoaFisica : Pessoa //Utilizar : para que as instâncias tenham acesso à todos os atributos da classe Pessoa
{
    public string cpf { get; set; }

    public string rg { get; set; }

    public DateTime DataNascimento { get; set; }
}

}

