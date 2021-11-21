using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BankCommoditiesControllers
{
    public class BackUpController
    {
        public static string GetBackUpJSon(string backupPath)
        {
            if (File.Exists(backupPath))
                return File.ReadAllText(backupPath);
            else
                return string.Empty;
        }

        public static void SetBackUpJSon(string backupPath, string jsonFile)
        {
            if (File.Exists(backupPath))
                File.Delete(backupPath);

            File.WriteAllText(backupPath, jsonFile);
        }
    }
}
