using System;
namespace OWCE_Web
{
    public static class CDN
    {
        public static string Path
        {
            get
            {
#if DEBUG
                return String.Empty;
#else
#if DEV
                return "https://devcdn.owce.app";
#else
                return "https://cdn.owce.app";
#endif
#endif
            }
        }
    }
}
