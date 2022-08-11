using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {

            Objetos.Cachorro Cachorro1 = new Objetos.Cachorro();
            Objetos.Gato Gato1 = new Objetos.Gato();
            Objetos.Cavalo Cavalo1 = new Objetos.Cavalo();

            EscolhaAnimal:
            Console.WriteLine("--- Tabela de animais ---");
            Console.WriteLine("-------- Digite: --------");
            Console.WriteLine("(1) para Cachorro");
            Console.WriteLine("(2) para Gato");
            Console.WriteLine("(3) para Cavalo");
            Console.WriteLine("-------------------------");
            string animalEscolhido = Console.ReadLine();

            switch (animalEscolhido)
            {
                case "1":
                    Console.WriteLine("--> Você escolheu Cachorro");
                    break;

                case "2":
                    Console.WriteLine("--> Você escolheu Gato");
                    break;

                case "3":
                    Console.WriteLine("--> Você escolheu Cavalo");
                    break;

                default:
                    Console.WriteLine("Animal inexistente, tente novamente!");
                    goto EscolhaAnimal;
                    
            }

            
            if(animalEscolhido == "1")
            {
                OpcoesCachorro:
                Console.Write("-- Digite: (A) para Andar ou (L) para Latir: ");
                string acaoEscolhidaC = Console.ReadLine();

                if(acaoEscolhidaC.ToUpper() == "A")
                {
                    Console.Write("-- Quantas vezes o cachorro irá andar?: ");
                    string QuantidadePassos = Console.ReadLine();
                    Cachorro1.AndarCachorro(QuantidadePassos);
                }

                else if(acaoEscolhidaC.ToUpper() == "L")
                {
                    Console.Write("-- Quantas vezes o cachorro irá latir?: ");
                    string QuantidadeLatido = Console.ReadLine();
                    Cachorro1.LatirCachorro(QuantidadeLatido);
                }

                else
                {
                    Console.WriteLine("Opção inválida, tente novamente!");
                    goto OpcoesCachorro;
                }
            }

            else if(animalEscolhido == "2")
            {   
                OpcoesGato:
                Console.Write("-- Digite: (A) para Andar ou (M) para Miar: ");
                string acaoEscolhidaG = Console.ReadLine();

               
                if (acaoEscolhidaG.ToUpper() == "A")
                {
                    Console.Write("-- Quantas vezes o gato irá andar?: ");
                    string QuantidadePassos = Console.ReadLine();
                    Gato1.AndarGato(QuantidadePassos);
                }

                else if (acaoEscolhidaG.ToUpper() == "M")
                {
                    Console.Write("-- Quantas vezes o gato irá miar?: ");
                    string QuantidadeMiado = Console.ReadLine();
                    Gato1.MiarGato(QuantidadeMiado);
                }

                else
                {
                    Console.WriteLine("Opção inválida, tente novamente!");
                    goto OpcoesGato;
                }
            }

            else if(animalEscolhido == "3")
            {
                Console.Write("-- Digite: (A) para Andar ou (R) para Relinchar: ");
                string acaoEscolhidaV = Console.ReadLine();

                OpcoesCavalo:
                if (acaoEscolhidaV.ToUpper() == "A")
                {
                    Console.Write("-- Quantas vezes o cavalo irá andar?: ");
                    string QuantidadePassos = Console.ReadLine();

                    Cavalo1.AndarCavalo(QuantidadePassos);
                }

                else if (acaoEscolhidaV.ToUpper() == "R")
                {
                    Console.Write("-- Quantas vezes o cavalo irá relinchar?: ");
                    string QuantidadeRe = Console.ReadLine();
                    Cavalo1.ReCavalo(QuantidadeRe);
                }

                else
                {
                    Console.WriteLine("Opção inválida, tente novamente!");
                    goto OpcoesCavalo;
                }
            }        
        }
    }
}
