using System;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static int MaxBattiti(int età)
        {
           int battiti = 220 - età;
           return battiti;
        }
    }
}
