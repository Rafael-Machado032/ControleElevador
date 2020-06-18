using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace ControleElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Controle exibir = new Controle();
            //exibir.andarMenosUtilizado();
            //exibir.elevadorMaisFrequentado();
            //exibir.elevadorMenosFrequentado();
            exibir.percentualDeUsoElevadorE();
            //exibir.periodoMaiorFluxoElevadorMaisFrequentado();
            //exibir.periodoMenorFluxoElevadorMenosFrequentado();
            //exibir.periodoMaiorUtilizacaoConjuntoElevadores();
        }
    }
}
