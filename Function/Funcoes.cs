using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronometro.Function
{
    public class Funcoes
    {
        public void Progressiva(int tempo)
        {
            int tempoAtual = 0;

            if (tempo < 0)
            {

            }
            else while (tempoAtual != tempo)
            {
                    tempoAtual++;
                    Thread.Sleep(1000);
            }
        }
        public void Regressiva(int tempo)
        {
            //Criar contagem regressiva
        }
    }
}
