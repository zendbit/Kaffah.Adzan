using System;
using Kaffah.Adzan.Internal;

namespace Kaffah.Adzan
{
    public class Qibla 
    {
        private readonly static Coordinates MAKKAH = new Coordinates(21.4225241, 39.8261818);

        public readonly double Direction;

        public Qibla(Coordinates coordinates) 
        {
            Direction = QiblaUtil.CalculateQiblaDirection(coordinates);
        }
    }
}