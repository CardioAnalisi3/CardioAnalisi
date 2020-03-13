using System;

namespace CardioLibrary
{
    public class DataCardio
    {
        public double CalcoloMaxBattitiCardiaci(int eta)
        {
            double maxbattiti = 0;
            maxbattiti= 220 - eta;
            return maxbattiti;
        }
        public double CalcoloMaxBattitiPalestra(int eta)
        {
            double maxbattiti = 0;
            double maxbattitipalestra = 0;
            maxbattiti = 220 - eta;
            maxbattitipalestra = (90 * maxbattiti) / 100;
            return maxbattitipalestra;
        }
        public string Battiti_Riposo(double battiti)
        {
            string risposta ="";
            if(battiti<60)
            {
                risposta = "Bradicardia";
            }
            if(battiti>=60 && battiti<=100)
            {
                risposta = "Battiti nella norma";
            }
            if(battiti>100)
            {
                risposta = "Tachicardia";
            }

        }
    }
}
