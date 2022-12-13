using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDarkSouls
{
    public class Personagem
    {
       

        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public string Sexo { get; set; }
        public string ItemIni { get; set; }

        public Personagem(string nome, int idade, double peso, string sexo, string itemIni)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Sexo = sexo;
            ItemIni = itemIni;
        }










    }
}
