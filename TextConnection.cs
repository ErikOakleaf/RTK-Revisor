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
    }
}
