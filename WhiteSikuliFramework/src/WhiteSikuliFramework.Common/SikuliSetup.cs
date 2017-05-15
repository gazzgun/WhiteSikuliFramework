using SikuliSharp;

namespace WhiteSikuliFramework.Common
{
    public static class SikuliSetup
    {
        public static ISikuliSession Session;

        public static ISikuliSession CreateSession()
        {
            Session = Sikuli.CreateSession();
            return Session;
        }

        public static ISikuliSession GetSession()
        {
            return Session;
        }

        public static bool ImageVerification(IPattern pattern)
        {
            return Session.Wait(pattern, 5);
        }
    }
}