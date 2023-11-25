using log4net;

namespace Test_Taste_Console_Application.Utilities
{
    public static class Logger
    {
        public static readonly ILog Instance = LogManager.GetLogger(typeof(Program));
    }
}
