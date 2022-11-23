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

        private CollectionModel collection;
        private List<FlashCardModel> currentFlashCards;
        private bool showEnglishAnswer = false;

        public RevisionForm(CollectionModel collection)
        {
            this.collection = collection;
            currentFlashCards = collection.FlashCards;
            InitializeComponent();
            ShowFirstPage();
            this.KeyPreview = true;
        }

        private void ShowFirstPage()
        {
            if (collection.FlashCards.Count > 0)
            {
                yesButton.Hide();
                noButton.Hide();
                flipButton.Show();
                if (!showEnglishAnswer)
                {
                    flashCardLabel.Text = currentFlashCards[0].Word;
                }
                else
                {
                    flashCardLabel.Text = currentFlashCards[0].Kanji;
                }
                rtkIndexLabel.Hide(); 
            }
            else
            {
                yesButton.Hide();
                noButton.Hide();
                flipButton.Hide();
                rtkIndexLabel.Hide();
                shuffleCheckBox.Hide();
                answerInEnglishCheckBox.Hide();
                flashCardLabel.Text = "Collection Completed !";
            }
        }

        private void flipCard()
        {
            if (!showEnglishAnswer)
            {
                flashCardLabel.Text = currentFlashCards[0].Kanji;
            }
            else
            {
                flashCardLabel.Text = currentFlashCards[0].Word;
            }
            scaleFont(flashCardLabel);
            rtkIndexLabel.Text = $"RTK Index: {currentFlashCards[0].RTKIndex}";
            rtkIndexLabel.Show();

            yesButton.Show();
            noButton.Show();
            flipButton.Hide();
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            flipCard();
        }
        private void scaleFont(Label lab)
        {
            Image fakeImage = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(fakeImage);

            SizeF extent = graphics.MeasureString(lab.Text, lab.Font);

            float hRatio = lab.Height / extent.Height;
            float wRatio = lab.Width / extent.Width;
            float ratio = (hRatio < wRatio) ? hRatio : wRatio;

            float newSize = lab.Font.Size * ratio;

            lab.Font = new Font(lab.Font.FontFamily, newSize, lab.Font.Style);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            FlashCardModel currentCard = currentFlashCards[0];
            // remove card from FlashCards list
            int x = 0;
            for (int i = 0; i < collection.FlashCards.Count; i++)
            {
                if (currentCard.RTKIndex == collection.FlashCards[i].RTKIndex)
                {
                    x = i;
                    break;
                }
            }
            collection.FlashCards.RemoveAt(x);

            // remove card from shuffledflashcards
            int y = 0;
            for (int i = 0; i < collection.ShuffledFlashCards.Count; i++)
            {
                if (currentCard.RTKIndex == collection.ShuffledFlashCards[i].RTKIndex)
                {
                    y = i;
                    break;
                }
            }
            collection.ShuffledFlashCards.RemoveAt(y);

            // Update removal of card to text file
            TextConnection connection = new TextConnection();
            connection.UpdateCollectionFile(collection);

            ShowFirstPage();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            // move the first flashcard to the end of the deck if currentFLashCards is normal flash card deck
            if (currentFlashCards == collection.FlashCards)
            {
                FlashCardModel tempFlashCard = currentFlashCards[0];
                currentFlashCards.RemoveAt(0);
                currentFlashCards.Add(tempFlashCard);
            }

            // move the first flashcard to the end of the deck if currentFlashCards is shuffled flash card deck.
            if (currentFlashCards == collection.ShuffledFlashCards)
            {
                FlashCardModel tempFlashCard = currentFlashCards[0];
                currentFlashCards.RemoveAt(0);
                currentFlashCards.Add(tempFlashCard);
            }

            // Update move of card to text file
            TextConnection connection = new TextConnection();
            connection.UpdateCollectionFile(collection);

            ShowFirstPage();
        }

        private void shuffleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (currentFlashCards == collection.FlashCards)
            {
                currentFlashCards = collection.ShuffledFlashCards;
            }
            else if (currentFlashCards == collection.ShuffledFlashCards)
            {
                currentFlashCards = collection.FlashCards;
            }
            ShowFirstPage();
        }

        private void answerInEnglishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!showEnglishAnswer)
            {
                showEnglishAnswer = true;
            }
            else if (showEnglishAnswer)
            {
                showEnglishAnswer = false;
            }

            ShowFirstPage();
        }

        private void RevisionForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                flipButton.PerformClick();
            }
            if (e.KeyCode == Keys.Z)
            {
                yesButton.PerformClick();
            }
            if (e.KeyCode == Keys.C)
            {
                noButton.PerformClick();
            }
        }
    }
}
