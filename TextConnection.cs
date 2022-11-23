using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RTK_Revisor.TextConnectionProcessor;

namespace RTK_Revisor
{
    public class TextConnection
    {
        public void SaveCollectionToFile(CollectionModel collection)
        {
            // Create folder collections if it does not exist
            string folderDirectory = GetPath("collections");
            if (!Directory.Exists(GetPath(folderDirectory)))
            {
                Directory.CreateDirectory(GetPath("collections"));
            }
            
            List<CollectionModel> collections = GetPath("collections", "collections.csv").LoadFile().ToList().ConvertToCollectionModels();
            collections.Add(collection);

            collections.WriteToCollectionsFile();

        }

        public void UpdateCollectionFile(CollectionModel collection)
        {
            List<CollectionModel> collections = GetPath("collections", "collections.csv").LoadFile().ToList().ConvertToCollectionModels();

            foreach (CollectionModel c in collections)
            {
                if (collection.Name == c.Name)
                {
                    c.FlashCards = collection.FlashCards;
                    c.ShuffledFlashCards = collection.ShuffledFlashCards;
                    break;
                }
            }

            collections.WriteToCollectionsFile();
        }

        public void UpdateAllCollections(List<CollectionModel> collections)
        {
            collections.WriteToCollectionsFile();
        }

        public void RemoveCollectionFromFile(CollectionModel collection)
        {
            List<CollectionModel> collections = GetPath("collections", "collections.csv").LoadFile().ToList().ConvertToCollectionModels();
            int x = 0;
            for (int i = 0; i < collections.Count; i++)
            {
                if (collections[i].Name == collection.Name)
                {
                    x = i;
                    break;
                }
            }

            collections.RemoveAt(x);
            collections.WriteToCollectionsFile();
        }
    }
}
