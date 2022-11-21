using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTK_Revisor
{
    public class CollectionModel
    {
        public List<DeckModel> Collection { get; set; }
        public string Name { get; set; }
        public CollectionModel()
        {
            Collection = new List<DeckModel>();
        }
    }
}
