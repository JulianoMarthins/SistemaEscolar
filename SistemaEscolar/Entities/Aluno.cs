using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SistemaEscolar.Entities {
    internal class Aluno {

        // Atributos
        public string Nome { get; private set; }
        private double[] _notas;


        // Construtor
        public Aluno(string nome, int qntProvas) {
            Nome = nome;
            _notas = new double[qntProvas];
        }


        // Metodos
        public double Media {
            get {
                return MediaNotas();
            }
        }

        public void InserirNotas() {
            
            for(int i = 0; i < _notas.Length; i++) {
                Console.Write($"Digite o valor da {i + 1}° prova: ");
                _notas[i] = double.Parse(Console.ReadLine());    
            }
        }

        private double MediaNotas() {

            double total = 0;

            for(int i = 0; i < _notas.Length; i++) {
                total += _notas[i];
            }

            return total / _notas.Length;            
        }

        
    }
}
