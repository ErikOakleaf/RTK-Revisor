﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RTK_Revisor.TextConnectionProcessor;


namespace RTK_Revisor
{
    public partial class CreateCollectionForm : Form
    {
        List<DeckModel> Lessons;
        List<DeckModel> AddedLessons;
        TextConnection connection;
        public CreateCollectionForm()
        {
            // initialize lessons lists
            Lessons = new List<DeckModel>();
            AddedLessons = new List<DeckModel>();
            connection = new TextConnection();

            InitializeComponent();
            InitializeLessons();
            WireUpLists();
        }

        private void InitializeLessons()
        {

            string[] lines = GetPath("data", "lessonIndexes.csv").LoadFile();
            string[] AllKanji = GetPath("data", "allKanji.csv").LoadFile();

            // iterate through each line in lessonIndexes file and add all of the flashcards from the indexes of that lesson in to a deck
            foreach (string line in lines)
            {
                DeckModel deck = new DeckModel();
                string[] cols = line.Split(',');
                deck.Name = $"Lesson {cols[0]}";

                string[] indexes = cols[1].Split(':');

                // iterate through every wanted index in allKanji file and add them as FLashCardModel to a DeckModel
                for (int i = int.Parse(indexes[0]) - 1; i < int.Parse(indexes[1]); i++)
                {
                    string[] info = AllKanji[i].Split(',');
                    FlashCardModel flashCard = new FlashCardModel();
                    flashCard.Kanji = info[0];
                    flashCard.Word = info[1];
                    flashCard.RTKIndex = info[2];
                    deck.Deck.Add(flashCard);
                }                

                Lessons.Add(deck);
            }
        }

        private void WireUpLists()
        {
            availableLessonsListBox.DataSource = null;
            availableLessonsListBox.DataSource = Lessons;
            availableLessonsListBox.DisplayMember = "Name";

            addedLessonsListBox.DataSource = null;
            addedLessonsListBox.DataSource = AddedLessons;
            addedLessonsListBox.DisplayMember = "Name";
        }

        private void addLessonButton_Click(object sender, EventArgs e)
        {
            if (availableLessonsListBox.SelectedItem != null)
            {
                DeckModel deck = (DeckModel)availableLessonsListBox.SelectedItem;
                AddedLessons.Insert(FindInsertionIndex(AddedLessons, int.Parse(deck.Name.Substring(6))), deck);
                Lessons.Remove(deck);
                WireUpLists(); 
            }
        }

        private void removeLessonButton_Click(object sender, EventArgs e)
        {
            if (addedLessonsListBox.SelectedItem != null)
            {
                DeckModel deck = (DeckModel)addedLessonsListBox.SelectedItem;
                Lessons.Insert(FindInsertionIndex(Lessons, int.Parse(deck.Name.Substring(6))), deck);
                AddedLessons.Remove(deck);
                WireUpLists(); 
            }
        }

        private int FindInsertionIndex(List<DeckModel> list, int lessonIndex)
        {
            if (list.Count < 1)
            {
                return 0;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (int.Parse(list[i].Name.Substring(6)) == lessonIndex - 1)
                    return i + 1;
                if (int.Parse(list[i].Name.Substring(6)) > lessonIndex)
                    return i;
            }
            if (int.Parse(list[^1].Name.Substring(6)) < lessonIndex)
                return list.Count;

            throw new Exception("Lesson Index is out of range");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CollectionModel collection = CreateCollection();

                connection.SaveCollectionToFile(collection);
                ButtonWasClicked();
                this.Close(); 
            }
        }

        private CollectionModel CreateCollection()
        {
            CollectionModel cm = new CollectionModel();

            // List of deck model exclusively made to pass in to the CreateCollectionName function to get name for the collection
            List<DeckModel> nameSetDeckCollection = new List<DeckModel>();
            foreach (DeckModel d in AddedLessons)
            {
                nameSetDeckCollection.Add(d);
            }

            foreach (DeckModel deck in AddedLessons)
            {
                foreach (FlashCardModel card in deck.Deck)
                {
                    cm.FlashCards.Add(card);
                }
            }
            cm.ShuffledFlashCards = new List<FlashCardModel>(cm.FlashCards);
            cm.ShuffledFlashCards.Shuffle();
            cm.OriginalFlashCards = new List<FlashCardModel>(cm.FlashCards);
            cm.Name = CreateCollectionName(nameSetDeckCollection);

            return cm;
        }

        public delegate void ClickButton();
        public event ClickButton ButtonWasClicked;

        private bool ValidateForm()
        {
            if (AddedLessons.Count == 0)
            {
                MessageBox.Show("Must add at least one lesson to create collection");
                return false;
            }

            // Check if the current deck that is trying to be made has the same name as another deck already created

            // List of deck model exclusively made to pass in to the CreateCollectionName function to get name for the collection
            List<DeckModel> nameSetDeckCollection = new List<DeckModel>();
            foreach (DeckModel d in AddedLessons)
            {
                nameSetDeckCollection.Add(d);
            }
            string currentName = CreateCollectionName(nameSetDeckCollection);

            List<CollectionModel> collections = GetPath("collections", "collections.csv").LoadFile().ToList().ConvertToCollectionModels();
            foreach (CollectionModel c in collections)
            {
                if (currentName == c.Name)
                {
                    DialogResult dialogResult = MessageBox.Show("This collection has alreay been created, do you want to initialize the deck?", "Deck already created", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TextConnection connection = new TextConnection();
                        connection.UpdateCollectionFile(CreateCollection());
                        ButtonWasClicked();
                        this.Close();
                    }
                    return false;
                }
            }
            return true;
        }

        private string CreateCollectionName(List<DeckModel> collection)
        {
            string str = "Lesson ";
            int firstLessonNumber = int.Parse(collection[0].Name.Substring(6));

            if (collection.Count == 1)
            {
                return str += firstLessonNumber;
            }
            else
            {
                // Loacl function to check if lessons are in order consecutive 
                bool IsConsecutive(List<DeckModel> collection)
                {
                    if (collection.Count == 1)
                    {
                        return false;
                    }
                    for (int i = 0; i < collection.Count - 1; i++)
                    {
                        int currentLessonNumber = int.Parse(collection[i].Name.Substring(6));
                        int nextLessonNumber = int.Parse(collection[i + 1].Name.Substring(6));

                        // check if next lesson is not equal to current lesson minus one
                        if (currentLessonNumber != nextLessonNumber - 1)
                        {
                            return false;
                        }
                    }
                    return true;
                }

                // loop through every index in the collection to see if the lesson numbers are consecutive
                int x = 0;
                while (x < collection.Count)
                {
                    bool isConsecutiveCheck = false;
                    // reverse for loop to check if any lessons are consecutive for each iteration of the loop integer j is later used to check if there where no consecutive lessons
                    int j = collection.Count;
                    for (int i = collection.Count; i > x; i--)
                    {
                        if (IsConsecutive(collection.GetRange(x, i - x)))
                        {
                            int xLessonNumber = int.Parse(collection[x].Name.Substring(6));
                            int iLessonNumber = int.Parse(collection[i - 1].Name.Substring(6));
                            str += $"{xLessonNumber} - {iLessonNumber} + ";
                            x += i - x - 1;
                            isConsecutiveCheck = true;
                            break;
                        }
                        j -= 1;
                    }



                    // if there are no consecutive lessons then just add the single lesson number to the name
                    if (!isConsecutiveCheck)
                    {
                        int currentLessonNumber = int.Parse(collection[x].Name.Substring(6));
                        str += $"{currentLessonNumber} + "; 
                    }

                    x++;
                }
            }
            str = str.Substring(0, str.Length - 2).Trim();
            return str;
        }
    }
}
