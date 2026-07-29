using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public static class DatabaseHelper
{
    // Ejecutar SELECT y devuelve DataTable
    public static DataTable ExecuteQuery(string sql, Dictionary<string, object> parameters = null)
    {
        using (var conn = new SQLiteConnection(Config.ConnectionString))
        {
            conn.Open();
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var p in parameters)
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                }

                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }

    // Ejecutar INSERT, UPDATE, DELETE
    public static int ExecuteNonQuery(string sql, Dictionary<string, object> parameters = null)
    {
        using (var conn = new SQLiteConnection(Config.ConnectionString))
        {
            conn.Open();
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var p in parameters)
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }

    // Para consulta que devuelve un solo valor 
    public static object ExecuteScalar(string sql, Dictionary<string, object> parameters = null)
    {
        using (var conn = new SQLiteConnection(Config.ConnectionString))
        {
            conn.Open();
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var p in parameters)
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                }
                return cmd.ExecuteScalar();
            }
        }
    }

    // Ejecuta SELECT y devuelve un DataReader
    public static SQLiteDataReader ExecuteReader(string sql, Dictionary<string, object> parameters = null)
    {
        var conn = new SQLiteConnection(Config.ConnectionString);
        conn.Open();
        var cmd = new SQLiteCommand(sql, conn);
        if (parameters != null)
        {
            foreach (var p in parameters)
                cmd.Parameters.AddWithValue(p.Key, p.Value);
        }
        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
    }

    //  ID del último registro insertado
    public static long GetLastInsertId()
    {
        return Convert.ToInt64(ExecuteScalar("SELECT last_insert_rowid();"));
    }
}