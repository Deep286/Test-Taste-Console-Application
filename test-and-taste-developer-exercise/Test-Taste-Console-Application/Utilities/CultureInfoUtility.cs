using System.Globalization;

namespace Test_Taste_Console_Application.Utilities
{
    public static class CultureInfoUtility
    {
        public static readonly TextInfo TextInfo = new CultureInfo("nl-BE").TextInfo;
    }
}
