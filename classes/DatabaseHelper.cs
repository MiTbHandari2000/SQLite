using System;
namespace SQLite.classes
{


    public class Databasetelper
    {
        public Databasetelper()
        {
        }
        public static bool Insert<T>(ref T data, string db_path)
        {
            using (var conn = new SQLite.SQLiteConnection(db_path))
            {
                conn.CreateTable<T>();
                if (conn.Insert(data) != 0)

                    return true;
            }
            return false;
        }
        public static bool Select<T>(ref T data, string db_path)
        {
            using (var conn = new SQLite.SQLiteConnection(db_path))
            {
                conn.CreateTable<T>();
                if (conn.Insert(data) != 0)

                    return true;
            }
            return false;
        }


    }
}