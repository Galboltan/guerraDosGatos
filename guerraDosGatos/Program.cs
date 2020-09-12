using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guerraDosGatos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Há muito tempo atrás");
            Console.ReadLine();
            Console.WriteLine("Um ser chamado gato1, tentou destruir toda a terra");
            Console.ReadLine();
            Console.WriteLine("Mas um gato guerreiro chamado gato Guerreiro, o derrotou");
            Console.ReadLine();
            Console.WriteLine("Porém, após escavaçoes na terra da erva de gato, o ser despertou");
            Console.ReadLine();
            Console.WriteLine("O destrua, e conheça mais sobre a historia da antiga Guerra dos Gatos...");
            Console.ReadLine();
            Console.WriteLine("");


            Random rnd = new Random();

            int m1 = rnd.Next(1, 10);
            int m2 = rnd.Next(1, 10);
            int m3 = rnd.Next(1, 10);
            int m4 = rnd.Next(1, 10);
            int forca = 0;
            int velocidade = 0;
            int magia = 0;
            int vida = 100;

            Console.WriteLine("Escolha sua classe");
            Console.WriteLine("Guerreiro (1) Mago (2) arqueiro(3)");
            short escolha1 = short.Parse(Console.ReadLine());

            Console.WriteLine("");

            switch (escolha1)
            {
                case 1:
                    Console.WriteLine("Você escolheu a classe de guerreiro");
                    Console.WriteLine("Você ganhou 20 de atk");
                    forca = 20;
                    Console.WriteLine("5 de speed");
                    velocidade = 5;
                    Console.WriteLine("E 1 de magia ");
                    magia = 1;
                    break;

                case 2:
                    Console.WriteLine("Você escolheu a classe de mago");
                    Console.WriteLine("Você ganhou 7 de atk");
                    forca = 7;
                    Console.WriteLine("8 de speed");
                    velocidade = 8;
                    Console.WriteLine("E 20 de magia ");
                    magia = 20;
                    break;

                case 3:
                    Console.WriteLine("Você escolheu a classe de arqueiro");
                    Console.WriteLine("Você ganhou 10 de atk");
                    forca = 10;
                    Console.WriteLine("7 de speed");
                    velocidade = 7;
                    Console.WriteLine("E 1 de magia ");
                    magia = 1;
                    break;

                default:
                    Console.WriteLine("Digite uma classe valida");
                    break;
            }

            if(escolha1 == 1)
            {
                Console.WriteLine("Olá guerreiro");
            }
            else if(escolha1 == 2)
            {
                Console.WriteLine("Olá mago");
            }
            else if(escolha1 == 3)
            {
                Console.WriteLine("Olá arqueiro");
            }


            Console.WriteLine("Qual o seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine($"{nome}, isso não me sou estranho...");
            Console.WriteLine("Espere, você é o escolhido 0_0");
            Console.ReadLine();
            Console.WriteLine("Não sei do que ele fala, decido me afastar");


            Console.WriteLine("Para onde você deseja ir ? (1) masmorras");
            string escolha2 = Console.ReadLine();

            if(escolha2 == "1")
            {
                Console.WriteLine("Enquanto sigo para as masmorras");
                Console.WriteLine("Noto que alguns seres estão se observando");

                if(m1 >= 5)
                {
                    int vidalobo = 40;
                    int ataqueLobo = 5;

                    Console.WriteLine("Lobo gigante ");
                    Console.WriteLine("Lobo ataca");
                    if(m2 >= 3)
                    {
                        vida -= 5;
                        Console.WriteLine($"Sua vida é de {vida}");
                    }

                    Console.WriteLine("Atacarrr");

                    
                    if(m4 >= 3)
                    {
                        while(vidalobo != 0)
                        {
                            Console.WriteLine("Atacarrr");
                            vidalobo -= 20;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Consegui matar ele");
                    }
                        

                }   
                
                
            }
                    



            Console.ReadLine();
        }
    }
}
