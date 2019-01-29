using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Models
{
    public class ProgramasAquecimento
    {
        private string _nome;
        private int _tempo;
        private int _potencia;
        private char _caracter;

        public ProgramasAquecimento()
        {
            
        }

        public ProgramasAquecimento(string nome, int tempo, int potencia, char carcter)
        {
            Nome = nome;
            Tempo = tempo;
            Potencia = potencia;
            Carcter = carcter;
            
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int Tempo { get => _tempo; set => _tempo = value; }
        public int Potencia { get => _potencia; set => _potencia = value; }
        public char Carcter { get => _caracter; set => _caracter = value; }
    }
}
