using System;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static int MisuraBattiti(int età)
        {
            if(età <= 100)
            { 
                int battiti = 220 - età;
                return battiti;
            }
            else
            {
                int battiti = 220 - età;
                return battiti;
            }
        }
    }
}
