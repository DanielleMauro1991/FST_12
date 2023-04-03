using System;

using Sistema_UC12.Classes;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        Pessoa novaPessoa = new Pessoa();
        novaPessoa.endereco = "rua niterou,1801";
        novaPessoa.nome = "Caique";
        novaPessoa.enderecoComercial = true;

        Console.WriteLine(novaPessoa.nome);
    }
}

