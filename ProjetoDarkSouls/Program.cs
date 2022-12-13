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
        static void Main(string[] args)
        {
            //int Re;
            Console.WriteLine("\n\n\n\n\n\n");
            //Console.WriteLine("                                                      --RPG--PROVER--\n");
            string start = @"
     _______   _______    ______         _______   _______    ______   __     __  ________  _______  
    /       \ /       \  /      \       /       \ /       \  /      \ /  |   /  |/        |/       \ 
    $$$$$$$  |$$$$$$$  |/$$$$$$  |      $$$$$$$  |$$$$$$$  |/$$$$$$  |$$ |   $$ |$$$$$$$$/ $$$$$$$  |
    $$ |__$$ |$$ |__$$ |$$ | _$$/       $$ |__$$ |$$ |__$$ |$$ |  $$ |$$ |   $$ |$$ |__    $$ |__$$ |
    $$    $$< $$    $$/ $$ |/    |      $$    $$/ $$    $$< $$ |  $$ |$$  \ /$$/ $$    |   $$    $$< 
    $$$$$$$  |$$$$$$$/  $$ |$$$$ |      $$$$$$$/  $$$$$$$  |$$ |  $$ | $$  /$$/  $$$$$/    $$$$$$$  |
    $$ |  $$ |$$ |      $$ \__$$ |      $$ |      $$ |  $$ |$$ \__$$ |  $$ $$/   $$ |_____ $$ |  $$ |
    $$ |  $$ |$$ |      $$    $$/       $$ |      $$ |  $$ |$$    $$/    $$$/    $$       |$$ |  $$ |
    $$/   $$/ $$/        $$$$$$/        $$/       $$/   $$/  $$$$$$/      $/     $$$$$$$$/ $$/   $$/ 
                                                                                                 
                                                                                                 
                                                                                                 
";
            Console.WriteLine(start);
            Console.WriteLine("                                               Pressione qualquer tecla "); ;
            

            while (Console.ReadKey(true).Key != ConsoleKey.Backspace)
            {
                
                Console.Clear();
                Console.WriteLine(" 1-Criar Novo Personagem\n 2-Editar Personagem\n 3-Finalizar Criação\n");
                var Re = Console.ReadKey();

                switch (Re.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        CriandoPerso();


                        break;
                    case '2':
                        Console.Clear();
                        break;
                    case '3':
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            Console.Write("\nPressione 'Back' para sair ...");
            }

            
        }
    }
}
