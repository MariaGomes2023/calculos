using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.Aritmetica;

namespace Calculos
{
    /// <summary>
    /// Implementa operaçoes de conversão
    /// </summary>
    internal static class conversoes
    {
        /// <summary>
        /// tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// tipo de conversão de distancias.
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }
        /// <summary>
        /// Conversao de temperaturas
        /// </summary>
        /// <param name="conversao">A conversao a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversao.</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }

            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;

        }
        /// <summary>
        /// Conversao de Distancias
        /// </summary>
        /// <param name="conversao">A conversao a efetuar</param>
        /// <param name="temperatura">A distancia a converter</param>
        /// <returns>Retorna o resultado da conversao.</returns>
        public static double ConverterDistancia(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return (distancia * 0.0006213712);
            }

            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return (distancia * 1609.344);
            }

            return -1;
        }
    }
}
