using System;
using System.IO;

namespace Test_Taste_Console_Application.Constants
{
    public static class PathName
    {
        public static readonly string ProjectDirectory = Environment.CurrentDirectory;
        public static readonly string PathToOutputFolder = Path.Combine(ProjectDirectory, FileOutputFolder);
        public const string FileOutputFolder = "FileOutput";
        public const string AllMoonsAndTheirMassFile = "AllMoonsAndTheirMass.csv";
        public const string AllPlanetsAndTheirMoonsFile = "AllPlanetsAndTheirMoons.csv";
        public const string AllPlanetsAndTheirAverageMoonTemperatureFile = "AllPlanetsAndTheirAverageMoonTemperature.csv";
    }
}
