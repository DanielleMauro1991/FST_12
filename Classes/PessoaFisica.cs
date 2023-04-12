using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC12.Classes

{

public class PessoaFisica : Pessoa //Utilizar : para que as instâncias tenham acesso à todos os atributos da classe Pessoa
{
    public string? cpf { get; set; }

    public string? rg { get; set; }

    public DateTime DataNascimento { get; set; }

    public override void PagarImposto (float rendimento){ //Colocamos o override para sobre escrever o método PagarImposto, pois ele já existe na classe-mãe

    }

    public bool ValidarDataNascimento (DateTime dataNasc){
        DateTime dataAtual = DateTime.Today;

        double anos = (dataAtual-dataNasc).TotalDays / 365; //Fórmula para obter a idade de uma pessoa

        if (anos >= 18){
            return true;
        } else {
            return false;
        }

    }
    
 }
}


