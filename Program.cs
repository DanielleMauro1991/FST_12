﻿using System;
using Sistema_UC12;
using Sistema_UC12.Classes;

class Program
{
    static void Main(string[] args) //Atalho svm + Enter
{
 
 Console.Clear(); //Comando necessário para o menu em cores
 Console.ForegroundColor = ConsoleColor.Magenta;
 //Console.BackgroundColor = ConsoleColor.DarkBlue;

 Console.WriteLine($"Seja bem vindo ao cadastro de pessoa física ou jurídica.");

 Console.WriteLine("Iniciando ");
 Thread.Sleep(500); //Cronômetro para barra de carregamento

//Comando para simular carregamento
 for(var contador = 0; contador < 10; contador++){
  Console.Write("▌ ");
  Thread.Sleep(500);
   }

 Console.ResetColor();// Comando necessário para que o console não saia na cor do menu

}

}

//Endereco end = new Endereco ();

//end.logradouro = "Rua Niterói";
//end.numero = 180;
//end.complemento = "Escola SENAI";
//end.enderecoComercial = true;

//PessoaFisica novapf = new PessoaFisica ();
//novapf.cpf = "080.733.239-90";
//novapf.endereco = end;
//novapf.DataNascimento = new DateTime (1991,06,16); //Padrão americano= Ano; mês; dia
//novapf.Nome = "Ygor Andrade";

//Console.WriteLine (novapf.endereco.logradouro);
//Console.WriteLine (novapf.endereco.numero);
//Console.WriteLine (novapf.endereco.complemento);
//Console.WriteLine (novapf.endereco.enderecoComercial);

//Console.WriteLine (novapf.Nome);
//Console.WriteLine (novapf.DataNascimento);

//Interpolação

//Console.WriteLine($"O endereço do {novapf.Nome} é {novapf.endereco.logradouro}, nº {novapf.endereco.numero}.");

//Concatenação

//Console.WriteLine ("O endereço do "+ novapf.Nome + " é " + novapf.endereco.logradouro + ", nº " + novapf.endereco.numero +".");

//bool idadeValidade = novapf.ValidarDataNascimento (novapf.DataNascimento);

//if (idadeValidade == true){
  //  Console.WriteLine ($"{novapf.Nome} é maior de idade");
//}else{
  //  Console.WriteLine ($"{novapf.Nome} é menor de idade");
//}

//PessoaJuridica novapj = new PessoaJuridica ();

//novapj.endereco = end;
//novapj.Nome = "SENAI";
//novapj.RazaoSocial = "Empresa";
//novapj.cnpj = "02518838990001";

//if (novapj.ValidarCNPJ(novapj.cnpj)){

  //Console.WriteLine ("CNPJ Válido");
  
  //}else{

    //Console.WriteLine ("CNPJ Inválido");
  //}
  //}
//}





