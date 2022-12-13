using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDarkSouls.Personagens;


namespace ProjetoDarkSouls
{
    partial class Program

    {
        static void CriandoPerso()
        {

            Console.WriteLine("Qual é o seu nome: ");
            string nome = Console.ReadLine();



            Console.WriteLine("Qual é a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Qual é o seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            //Skill.rolamento = peso;



            Console.WriteLine("Qual é o seu sexo: M/F ");
            string sexo = Console.ReadLine();

            Console.WriteLine(" Escolha seu item inicial : ");
            Console.WriteLine(" 1-Anel da Vida\n 2-Bomba Negra\n 3-Osso do Regresso\n 4-Coroa de Escamas\n 5-Medalhão de prata\n");
            var result = Console.ReadKey();
            string answ,itemIni="";

            switch (result.KeyChar)
            {
                case '1':
                    Console.WriteLine(" Então você escolhe o Anel da Vida,o item que dá vitalidade....  tem certeza ? ");
                    Console.WriteLine("--------->sim///////////---------->não");
                    answ=Console.ReadLine();
                    if (answ == "sim")
                    {
                        itemIni = "Anel da Vida";
                    }
                    else
                    {

                    }
                    break;
                case '2':
                    Console.WriteLine(" Então você escolhe a Bomba negra, o mais poderoso explosivo... tem certeza ? ");
                    Console.WriteLine("--------->sim///////////---------->não");
                    answ = Console.ReadLine();
                    if (answ == "sim")
                    {
                        itemIni = "Bomba Negra";
                    }
                    else
                    {

                    }
                    break;
                case '3':
                    Console.WriteLine(" Então você escolhe o Osso do regresso,o item de retornar a qualquer lugar já passado.... tem certeza ? ");
                    Console.WriteLine("--------->sim///////////---------->não");
                    answ = Console.ReadLine();
                    if (answ == "sim")
                    {
                        itemIni = "Osso do regresso";
                    }
                    else
                    {

                    }
                    break;
                case '4':
                    Console.WriteLine(" Então você escolhe a coroa de escamas,o estranho item de camuflagem.... tem certeza ? ");
                    Console.WriteLine("--------->sim///////////---------->não");
                    answ = Console.ReadLine();
                    if (answ == "sim")
                    {
                        itemIni = "Coroa de Escamas";
                    }
                    else
                    {

                    }
                    break;
                case '5':

                    Console.WriteLine(" Então você escolhe o Medalhão de prata,o misterioso item de poder desconhecido.... tem certeza ? ");
                    Console.WriteLine("--------->sim///////////---------->não");
                    answ = Console.ReadLine();
                    if (answ == "sim")
                    {
                        itemIni = "Medalhão de Prata";
                    }
                    else
                    {

                    }
                    break;
                default:
                    break;
            }

            //Console.WriteLine("Selecione o seu item inical: ");
            
            /* string[] menuOptions = new string[] { "Anel da Vida\t", "Bomba Negra\t", "Osso do Regresso\t", "Coroa de escamas\t", "medalhão de prata\t" };
             int menuSelect = 0;

             while (true)
             {
                 Console.Clear();
                 Console.CursorVisible = false;
                 Console.WriteLine("Escolha seu item inicial :");

                 for (int i = 0; i < menuOptions.Length; i++)
                 {
                     Console.WriteLine((i == menuSelect ? "* " : "") + menuOptions[i] + (i == menuSelect ? "<--" : ""));

                 }

                 var keyPressed = Console.ReadKey();

                 if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                 {
                     Console.WriteLine(menuSelect);
                     menuSelect++;
                 }
                 else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                 {
                     menuSelect--;
                     Console.WriteLine(menuSelect);
                 }

                 else if (keyPressed.Key == ConsoleKey.Enter)
                 {
                     Console.WriteLine(menuSelect);
                     switch (menuSelect)
                     {
                         case 0:
                             Console.WriteLine(" Então você escolhe o Anel da Vida,o item que adiciona longevidade....  tem certeza ? ");
                             break;
                         case 1:
                             Console.WriteLine(" Então você escolhe a Bomba negra, o mais poderoso explosivo... tem certeza ? ");
                             break;
                         case 2:
                             Console.WriteLine(" Então você escolhe o Osso do regresso,o item de retornar a qualquer lugar já passado.... tem certeza ? ");
                             break;
                         case 3:
                             Console.WriteLine(" Então você escolhe a coroa de escamas,o estranho item de camuflagem.... tem certeza ? ");
                             break;
                         case 4:
                             Console.WriteLine(" Então você escolhe o Medalhão de prata,o misterioso item de poder desconhecido.... tem certeza ? ");
                             break;
                     }
                 }
             }
             //resultados();*/


            





            Personagem cj = new Personagem(nome, idade, peso, sexo, itemIni);

        }


        

           
        
    }
}
