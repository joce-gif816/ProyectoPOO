using System;
using System.IO;

public static class Config
{
    public static string ConnectionString
    {
        get
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(appDirectory, "GestorPooDB.db");

            if (!File.Exists(dbPath))
            {
                string projectDirectory = Directory.GetParent(appDirectory).Parent.Parent.FullName;
                dbPath = Path.Combine(projectDirectory, "GestorPooDB.db");
            }

            return $"Data Source={dbPath};Version=3;";
        }
    }
}