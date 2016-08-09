using EloBuddy;
using EloBuddy.SDK.Events;

namespace PortAIO_Loader
{
    class Program
    {
        public static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static void Loading_OnLoadingComplete(System.EventArgs args)
        {
            PortAIO.Init.Initialize();
        }
    }
}
