using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDarkSouls.Classes
{
    public class Guerreiro : Classe
    {
        public void Cle()
        {
            Console.WriteLine("o card do Clérigo é:  ");
            Inteligencia = 8;
            Força = 12;
            Fe = 16;
            Vitalidade = 11;
            Energia = 10;
            Magia = 11;
            Defesa = 11;
            Vigor = 9;
            Console.WriteLine("Está satisfeito");
        }
    }
}
