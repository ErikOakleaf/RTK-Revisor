using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTK_Revisor
{
    public class DeckModel
    {
        public string Name { get; set; }
        public List<FlashCardModel> Deck { get; set; }
        public DeckModel()
        {
            Deck = new List<FlashCardModel>();
        }
    }
}
