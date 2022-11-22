using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTK_Revisor
{
    public class CollectionModel
    {
        public List<FlashCardModel> FlashCards { get; set; }
        public List<FlashCardModel> ShuffledFlashCards { get; set; }
        public List<FlashCardModel> OriginalFlashCards { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public CollectionModel()
        {
            FlashCards = new List<FlashCardModel>();
            ShuffledFlashCards= new List<FlashCardModel>();
            OriginalFlashCards= new List<FlashCardModel>();
            IsCompleted = false;
        }
    }
}
