using System;
using System.Globalization;
using System.Security.AccessControl;
using SisVeterinaria.Entities;

namespace SisVeterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadastro de clientes

            Cliente cliente;
            Animal animal = null;
            Especie especie;
            Tratamento tratamentos;
            Exame exame;
            Veterinario veterinario;
            Consulta consulta = null;

            Console.WriteLine("Cadastro de cliente");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Endereco: ");
            string endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            cliente = new Cliente(nome, endereco, telefone);

            //Cadastro de Animais
            Console.WriteLine("Cadastro de animais");
            Console.Write("Quantos animais serão cadastrados? ");
            int nAnimais = int.Parse(Console.ReadLine());

            for(int i = 0; i < nAnimais; i++)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Sexo Femia(F) ou Macho(M): ");
                char sexo = char.Parse(Console.ReadLine());
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Especie: ");
                string especieAnimal = Console.ReadLine();

                especie = new Especie(especieAnimal);
                animal = new Animal(nome, sexo, idade, especie);
                cliente.AddAnimais(animal);

                //Adicionar tratamento e Consulta

                tratamentos = new Tratamento();
                Console.Write("Quantos tratamentos o animal realizará: ");
                int nTratamentos = int.Parse(Console.ReadLine());
                Console.WriteLine("Agendar consulta");

                for (int j = 0; j < nTratamentos; j++)
                {
                    Console.Write("Data: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Console.Write("Resumo da consulta: ");
                    string resumo = Console.ReadLine();
                    Console.Write("Nome do veterinário: ");
                    string nomeVeterinario = Console.ReadLine();

                    veterinario = new Veterinario(nomeVeterinario);
                    consulta = new Consulta(data, resumo, veterinario);

                    //Adicionar Exame
                    Console.WriteLine("Realizar exame:");
                    Console.WriteLine("Quantos exames serão realizados?");
                    int nExames = int.Parse(Console.ReadLine());
                    
                    for (int e = 0; e < nExames; e++)
                    {
                        Console.Write("Nome exame: ");

                        string nomeExame = Console.ReadLine();
                        exame = new Exame(nomeExame);
                        consulta.AddExames(exame);

                        tratamentos.AddConsultas(consulta);
                    }
                }
                
            }

            Console.WriteLine(cliente);
            cliente.ListarAnimais();

            animal.ListarTratamentos();
            consulta.ListarExames();
        }
    }
}