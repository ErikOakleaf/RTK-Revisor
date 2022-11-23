using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RTK_Revisor
{
    public static class TextConnectionProcessor
    {
        public static string GetPath(string folder)
        {

            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (!directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return Path.Combine(directory.ToString(), folder);
        }
        public static string GetPath(string folder, string file)
        {

            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (!directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return Path.Combine(directory.ToString(), folder, file);
        }
        public static string[] LoadFile(this string path)
        {
            if (!File.Exists(path))
            {
                return new string[0];
            }
            else
            {
                return File.ReadAllLines(path);
            }
        }

        public static void WriteToCollectionsFile(this List<CollectionModel> collections)
        {
            string filePath = GetPath("collections", "collections.csv");

            List<string> lines = new List<string>();
            foreach (CollectionModel c in collections)
            {
                // Get all id's from the (possibly) modified flash cards
                string idStr = "";
                string idStr2 = "";

                if (c.FlashCards.Count > 0)
                {
                    foreach (FlashCardModel fc in c.FlashCards)
                    {
                        idStr += $"{fc.RTKIndex}:";
                    }
                    idStr = idStr.Substring(0, idStr.Length - 1);

                    // Get all id's for shuffled flash cards

                    foreach (FlashCardModel fc in c.ShuffledFlashCards)
                    {
                        idStr2 += $"{fc.RTKIndex}:";
                    }
                    idStr2 = idStr2.Substring(0, idStr2.Length - 1); 
                }
                // Get all id's from the OriginalFlashCards
                string idStr3 = "";
                foreach (FlashCardModel fc in c.OriginalFlashCards)
                {
                    idStr3 += $"{fc.RTKIndex}:";
                }
                idStr3 = idStr3.Substring(0, idStr3.Length - 1);

                lines.Add($"{c.Name},{idStr},{idStr2},{idStr3}");
            }
            File.WriteAllLines(filePath, lines);
        }

        public static List<CollectionModel> ConvertToCollectionModels(this List<string> lines)
        {
            string[] AllKanji = GetPath("data", "allKanji.csv").LoadFile();
           List<CollectionModel> collections = new List<CollectionModel>();
            foreach (string line in lines)
            {
                CollectionModel c = new CollectionModel();
                string[] cols = line.Split(',');
                c.Name = cols[0];

                string[] flashCardsIds= cols[1].Split(":");
                if (flashCardsIds[0] != "")
                {
                    foreach (string id in flashCardsIds)
                    {
                        FlashCardModel fc = new FlashCardModel();
                        string[] info = AllKanji[int.Parse(id) - 1].Split(',');
                        fc.Kanji = info[0];
                        fc.Word = info[1];
                        fc.RTKIndex = info[2];
                        c.FlashCards.Add(fc);
                    } 
                }

                string[] shuffledFlashCardIds = cols[2].Split(":");
                if (shuffledFlashCardIds[0] != "")
                {
                    foreach (string id in shuffledFlashCardIds)
                    {
                        FlashCardModel fc = new FlashCardModel();
                        string[] info = AllKanji[int.Parse(id) - 1].Split(',');
                        fc.Kanji = info[0];
                        fc.Word = info[1];
                        fc.RTKIndex = info[2];
                        c.ShuffledFlashCards.Add(fc);
                    } 
                }

                string[] originalFlashCardIds = cols[3].Split(":");
                foreach (string id in originalFlashCardIds)
                {
                    FlashCardModel fc = new FlashCardModel();
                    string[] info = AllKanji[int.Parse(id) - 1].Split(',');
                    fc.Kanji = info[0];
                    fc.Word = info[1];
                    fc.RTKIndex = info[2];
                    c.OriginalFlashCards.Add(fc);
                }
                collections.Add(c);
            }
            return collections;
        }

        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
