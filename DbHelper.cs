//using SQLite;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using YorubaCatholicHymn.Models;

//namespace YorubaCatholicHymn
//{
//    public static class DbHelper
//    {
//        private static string PickExistingTable(SQLiteConnection conn, params string[] candidates)
//        {
//            foreach (var name in candidates)
//            {
//                try
//                {
//                    if (conn.GetTableInfo(name)?.Count > 0)
//                        return name;
//                }
//                catch
//                {
//                    // Ignore and try next candidate.
//                }
//            }

//            // Fall back to first candidate; the caller will get the real SQLite error.
//            return candidates.Length > 0 ? candidates[0] : string.Empty;
//        }

//        public static string GetDatabasePath()
//        {
//            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "hymns.db");

//            static void CopyPackagedDb(string destinationPath)
//            {
//                using var stream = FileSystem.OpenAppPackageFileAsync("hymns.db").Result;
//                using var fileStream = File.Create(destinationPath);
//                stream.CopyTo(fileStream);
//            }

//            var needsCopy = !File.Exists(dbPath);

//#if DEBUG
//            // During debugging it's common to update the packaged DB; always refresh the app-data copy
//            // so changes in Resources/Raw/hymns.db are reflected immediately.
//            needsCopy = true;
//#endif

//            // If a previous run created a bad/empty DB file, replace it.
//            if (!needsCopy)
//            {
//                try
//                {
//                    var fileInfo = new FileInfo(dbPath);
//                    if (fileInfo.Length < 1024) // real SQLite DBs won't be this small
//                    {
//                        needsCopy = true;
//                    }
//                    else
//                    {
//                        using var conn = new SQLiteConnection(dbPath);
//                        var hasHymnTable = (conn.GetTableInfo("Hymn")?.Count > 0) || (conn.GetTableInfo("Hymns")?.Count > 0);
//                        var hasVerseTable = (conn.GetTableInfo("Verse")?.Count > 0) || (conn.GetTableInfo("Verses")?.Count > 0);
//                        if (!hasHymnTable || !hasVerseTable)
//                            needsCopy = true;
//                    }
//                }
//                catch
//                {
//                    needsCopy = true;
//                }
//            }

//            if (needsCopy)
//            {
//                try
//                {
//                    if (File.Exists(dbPath))
//                        File.Delete(dbPath);
//                }
//                catch
//                {
//                    // If delete fails, CopyPackagedDb will throw with a clearer error.
//                }

//                CopyPackagedDb(dbPath);
//            }

//            return dbPath;
//        }
//        public static void NormalizeVerseText(SQLiteConnection conn)
//        {
//            // Normalize CRLF and CR to LF
//            conn.Execute("UPDATE Verse SET Text = REPLACE(Text, CHAR(13) || CHAR(10), CHAR(10));");
//            conn.Execute("UPDATE Verse SET Text = REPLACE(Text, CHAR(13), CHAR(10));");

//            // Remove replacement boxes (�)
//            conn.Execute("UPDATE Verse SET Text = REPLACE(Text, '�', '');");

//            // Trim whitespace
//            conn.Execute("UPDATE Verse SET Text = TRIM(Text);");
//        }

//        public static List<string> GetCategories()
//        {
//            using var conn = new SQLiteConnection(GetDatabasePath());
//            return conn.Table<Hymn>().Select(h => h.Category).Distinct().ToList();
//        }

//        public static List<Hymn> GetHymnsWithVerses(string category = "All")
//        {
//            using var conn = new SQLiteConnection(GetDatabasePath());
//            var query = conn.Table<Hymn>();

//            if (!string.IsNullOrEmpty(category) && category != "All")
//                query = query.Where(h => h.Category == category);

//            var hymns = query.ToList();

//            foreach (var hymn in hymns)
//            {
//                hymn.Verses = conn.Table<Verse>()
//                                  .Where(v => v.HymnId == hymn.Id)
//                                  .OrderBy(v => v.Id)
//                                  .ToList();
//            }

//            return hymns;
//        }
//    }
//}
