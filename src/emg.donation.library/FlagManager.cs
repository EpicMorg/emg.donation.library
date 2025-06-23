using System;
using System.IO;

namespace emg.donation.library
{
    public static class FlagManager
    {
        private static string GetAppFolder(string appId)
        {
            var baseDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //return Path.Combine(baseDir, "EpicMorg", "emg.donation.library", appId

            // dotnet2.0 does not support nested directories in Path.Combine, so we do it manually
            string p = Path.Combine(baseDir, "EpicMorg");
            p = Path.Combine(p, "emg.donation.library");
            p = Path.Combine(p, appId);
            return p;
        }

        public static bool FileExists(string appId, string fileName)
        {
            var path = Path.Combine(GetAppFolder(appId), fileName);
            return File.Exists(path);
        }

        public static void WriteFlag(string appId, string fileName, string content = null)
        {
            var folder = GetAppFolder(appId);
            Directory.CreateDirectory(folder);
            var path = Path.Combine(folder, fileName);
            File.WriteAllText(path, content ?? DateTime.UtcNow.ToString("o"));
        }

        public static DateTime? ReadFlagDate(string appId, string fileName)
        {
            try
            {
                var path = Path.Combine(GetAppFolder(appId), fileName);
                if (!File.Exists(path))
                    return null;
                var text = File.ReadAllText(path);
                return DateTime.Parse(text);
            }
            catch
            {
                return null;
            }
        }

        public static void DeleteFlag(string appId, string fileName)
        {
            try
            {
                var path = Path.Combine(GetAppFolder(appId), fileName);
                if (File.Exists(path))
                    File.Delete(path);
            }
            catch
            {
            }
        }
    }
}
