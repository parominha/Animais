using System;
using System.Collections.Generic;
using System.Text;

namespace Animais.Objetos
{
    class Gato
    {
        public void AndarGato(string AcaoAndarGato)
        {
            string espacoGato = "";

            for (int i = 0; i < int.Parse(AcaoAndarGato); i++)
            {
                Console.WriteLine(espacoGato + "(>.<)");
                espacoGato = espacoGato + " ";
            }
        }

        public void MiarGato(string AcaoMiarGato)

        {
            for (int i = 0; i < int.Parse(AcaoMiarGato); i++)
            {
                Console.WriteLine("Meeoow!");
            }
        }

    }
}
