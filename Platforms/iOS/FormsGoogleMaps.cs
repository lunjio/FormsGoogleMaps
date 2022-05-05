using System;
using Google.Maps;

namespace Xamarin.Forms.GoogleMaps.iOS
{
    public static class FormsGoogleMaps
    {
        public static bool IsInitialized { get; private set; }

        public static void Init(string apiKey, PlatformConfig config = null)
        {
            MapServices.ProvideApiKey(apiKey);
            GeocoderBackend.Register();
            MapRenderer.Config = config ?? new PlatformConfig();
            IsInitialized = true;
        }
    }
}

