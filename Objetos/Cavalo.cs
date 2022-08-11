using System;
using System.Collections.Generic;
using System.Text;

namespace Animais.Objetos
{
    class Cavalo
    {
        public void AndarCavalo(string AcaoAndarCavalo)
        {
            string espacoCavalo = "";

            for (int i = 0; i < int.Parse(AcaoAndarCavalo); i++)
            {
                Console.WriteLine(espacoCavalo + "*pocotó*");
                espacoCavalo = espacoCavalo + " ";
            }
        }

        public void ReCavalo(string AcaoReCavalo)

        {
            for (int i = 0; i < int.Parse(AcaoReCavalo); i++)
            {
                Console.WriteLine("Hiiihihôo~");
            }
        }
    }
}
