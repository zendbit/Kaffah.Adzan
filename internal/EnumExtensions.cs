using System;

namespace Kaffah.Adzan.Internal
{
    public static class EnumExtensions
    {      
        public static ShadowLength GetShadowLength(this Madhab madhab)
        {
            switch (madhab) 
            {
                case Madhab.SHAFI: 
                    return ShadowLength.Single;      
                case Madhab.HANAFI: 
                    return ShadowLength.Double;
                default: 
                    throw new ArgumentException("Invalid Madhab");
            }
        }
    }
}
