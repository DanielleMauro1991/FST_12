using System;
using Sistema_UC12.Classes;

class Program
{
    static void Main(string[] args) //Atalho svm + Enter
{

Endereco end = new Endereco ();

end.logradouro = "Rua Niterói";
end.numero = 180;
end.complemento = "Escola SENAI";
end.enderecoComercial = true;

PessoaFisica novapf = new PessoaFisica ();
novapf.cpf = "080.733.239-90";
novapf.endereco = end;
novapf.DataNascimento = new DateTime (1991,06,16); //Padrão americano= Ano; mês; dia
novapf.Nome = "Ygor Andrade";

//Console.WriteLine (novapf.endereco.logradouro);
//Console.WriteLine (novapf.endereco.numero);
//Console.WriteLine (novapf.endereco.complemento);
//Console.WriteLine (novapf.endereco.enderecoComercial);

//Console.WriteLine (novapf.Nome);
//Console.WriteLine (novapf.DataNascimento);

//Interpolação

Console.WriteLine($"O endereço do {novapf.Nome} é {novapf.endereco.logradouro}, nº {novapf.endereco.numero}.");

//Concatenação

Console.WriteLine ("O endereço do "+ novapf.Nome + " é " + novapf.endereco.logradouro + ", nº " + novapf.endereco.numero +".");

}

}

