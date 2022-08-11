using System;
using System.Collections.Generic;
using System.Text;

namespace Animais.Objetos
{
    class Cachorro
    {
        public void AndarCachorro(string AcaoAndarCachorro)
        {
            string espacoCachorro = "";

            for (int i = 0; i < int.Parse(AcaoAndarCachorro); i++)
            {
                Console.WriteLine(espacoCachorro + "*pat pat*");
                espacoCachorro = espacoCachorro + " ";
            }
                             
        }

        public void LatirCachorro(string AcaoLatirCachorro)

        {
            for (int i = 0; i < int.Parse(AcaoLatirCachorro); i++)
            {
                Console.WriteLine("AU AU!");            
            }
        }
        
    }
}
