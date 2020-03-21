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
        public double CalorieBruciateUomo(int durata, double peso, double FrequenzaCardiacaMedia, int eta)
        {
            double calorie = 0;
            calorie = (( eta * 0.2017) + (peso * 0.199) + (FrequenzaCardiacaMedia + 0.6309) - 55.0969) * durata / 4.184;
            calorie = Math.Round(calorie, 2);
            return calorie;
        }
        public double CalorieBruciateDonne (int durata, double peso, double FrequenzaCardiacaMedia, int eta)
        {
            double calorie = 0;
            calorie = ((eta * 0.074) + (peso * 0.126) + (FrequenzaCardiacaMedia + 0.4472) - 20.4022) * durata / 4.184;
            calorie = Math.Round(calorie, 2);
            return calorie;
        }
        public double SpesaEnergeticaCorsa (int DistanzaPercorsa, int PesoCorporeo)
        {
            double SpesaEnergetica = 0.9 * DistanzaPercorsa + PesoCorporeo;
            SpesaEnergetica = Math.Round(SpesaEnergetica, 2);
            return SpesaEnergetica;
        }
        public double SpesaEnergeticaCamminata (int DistanzaPercorsa, int PesoCorporeo)
        {
            double SpesaEnergetica = 0.50 * DistanzaPercorsa + PesoCorporeo;
            SpesaEnergetica = Math.Round(SpesaEnergetica, 2);
            return SpesaEnergetica;
        }
        public double CalcoloMaxBattitiCamminata (int eta)
        {
            double maxbattiti = 0;
            double maxbattiticamminata = 0; 
            maxbattiti = 220 - eta;
            maxbattiticamminata = (59 * maxbattiti) / 100;
            return maxbattiticamminata;
        }
        public double CalcoloMinBattitiCamminata (int eta)
        {
            double minbattiti = 0;
            double minbattiticamminata = 0; 
            minbattiti = 220 - eta;
            minbattiticamminata = (50 * maxbattiti) / 100;
            return minbattiticamminata;
        }
        public double CalcoloMaxBattitiAerobica (int eta)
        {
            double maxbattiti = 0;
            double maxbattitiaerobica = 0; 
            maxbattiti = 220 - eta;
            maxbattitiaerobica = (79 * maxbattiti) / 100;
            return maxbattitiaerobica;
        }
        public double CalcoloMinBattitiAerobica (int eta)
        {
            double minbattiti = 0;
            double minbattitiaerobica = 0; 
            minbattiti = 220 - eta;
            minbattitiaerobica = (70 * minbattiti) / 100;
            return minbattitiaerobica;
        }
        public double CalcoloMediaBattitiAlGiorno (int [] battitiorari)
        {
            double media = 0;
            for (int i = 0; i < battitiorari.Lenght; i++)
            {
                media = media + battitiorari[i];
            }
            media = media / battitiorari.Lenght;
            return media;
        }
        public double CalcoloMediaBattitiAlRiposo(int[]battitiARiposo)
        {
            double media = CalcoloMediaBattitiAlGiorno(battitiARiposo);
            return media;
        }
    }
}
