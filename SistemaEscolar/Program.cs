using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaEscolar.Entities;

namespace SistemaEscolar {
    internal class Program {
        static void Main(string[] args) {

            Console.Title = "Programado por JulianoMarthins";

            Console.Write("Quantos alunos: ");
            int numAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[numAlunos];


            for(int i = 0; i < alunos.Length; i++) {
                
                Console.Clear();

                Console.Write($"{i + 1}° Aluno\nDigite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write($"Quantidade de provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine($"\nInsira as notas do aluno {nome}: ");

                alunos[i].InserirNotas();

            }

            Console.Clear();

            double mediaGeral = 0;

            foreach(Aluno aluno in alunos) {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Media: {aluno.Media.ToString("F2")}");

                Console.WriteLine();

                mediaGeral += aluno.Media;

            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine($"Media geral dos alunos: {resultadoFinal.ToString("F2")}");


            
        }
    }
}
