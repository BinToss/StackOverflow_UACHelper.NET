namespace SODNUACH
{
    public static class TargetFramework
    {
        public enum Versions
        {
            unknown,
            NET40,
            NET45,
            NET451,
            NET452,
            NET46,
            NET461,
            NET462,
            NET472,
            NET48
        }

        public static Versions Version
        {
            get

            {
#if NET40
                return Versions.NET40;
#elif NET45
                return Versions.NET45;
#elif NET451
                return Versions.NET451;
#elif NET452
                return Versions.NET452;
#elif NET46
                return Versions.NET46;
#elif NET461
                return Versions.NET461;
#elif NET462
                return Versions.NET462;
#elif NET472
                return Versions.NET472;
#elif NET48
                return Versions.NET48;
#else
                return Versions.unknown;
#endif
            }
        }
    }
}