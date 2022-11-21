using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTK_Revisor
{
    public partial class RevisionForm : Form
    {

        public CollectionModel collection;
        public DeckModel deck;
        private int currentIndex = 0;

        //sample data


        public RevisionForm(CollectionModel collection)
        {
            this.collection = collection;
            InitializeComponent();
            InitializeDeck();
            InitializeForm();
        }

        private void InitializeDeck()
        {
            deck = new DeckModel();
            foreach (DeckModel d in collection.Collection)
            {
                deck.Deck.AddRange(d.Deck);
            }
        }

        private void InitializeForm()
        {
            yesButton.Hide();
            noButton.Hide();
        }

        private void WireUpLists()
        {
            flashCardLabel.Text = deck.Deck[currentIndex].Word;
        }
    }
}
