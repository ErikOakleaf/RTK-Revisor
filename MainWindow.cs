using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RTK_Revisor.TextConnectionProcessor;

namespace RTK_Revisor
{
    public partial class MainWindow : Form
    {
        public string[] AllKanji { get; set; }
        public List<string> AvaliableKanji { get; set; } = new List<string>();
        public List<CollectionModel> Collections { get; set; }
        public Regex JapaneseRegex { get; set; }
        public MainWindow()
        {
            AllKanji = GetPath("data", "allKanji.csv").LoadFile();
            JapaneseRegex = new Regex(@"[\u3040-\u30ff\u3400-\u4dbf\u4e00-\u9fff\uf900-\ufaff\uff66-\uff9f]");

            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            kanjiListBox.Items.Clear();
            foreach (string s in AvaliableKanji)
            {
                kanjiListBox.Items.Add(s);
            }

            Collections = GetPath("collections", "collections.csv").LoadFile().ToList().ConvertToCollectionModels();

            collectionListBox.DataSource = null;
            collectionListBox.DataSource = Collections;
            collectionListBox.DisplayMember = "Name";
        }

        private void kanjiSearchBox_TextChanged(object sender, EventArgs e)
        {
            // check if string is a number
            if (int.TryParse(kanjiSearchBox.Text, out int x))
            {
                KanjiSearch(2);
            }
            else if (JapaneseRegex.IsMatch(kanjiSearchBox.Text))
            {
                KanjiSearch(0);
            }
            else
            {
                KanjiSearch(1);
            }
        }

        private void KanjiSearch(int col)
        {
            AvaliableKanji.Clear();
            string searchText = kanjiSearchBox.Text;

            if (kanjiSearchBox.Text.Length > 0)
            {
                foreach (string str in AllKanji)
                {
                    string[] cols = str.Split(',');
                    string referenceWord = cols[col];

                    int j = 0;

                    if (searchText.Length <= referenceWord.Length)
                    {
                        for (int i = 0; i < searchText.Length; i++)
                        {
                            if (searchText[i] == referenceWord[i])
                            {
                                j++;
                            }
                        }

                        if (j == searchText.Length)
                        {
                            AvaliableKanji.Add(str);
                        }
                    }
                }
            }
            WireUpLists();
        }

        private void createCollectionButton_Click(object sender, EventArgs e)
        {
            CreateCollectionForm ccf = new CreateCollectionForm();
            ccf.Show();
            ccf.ButtonWasClicked += new CreateCollectionForm.ClickButton(WireUpLists);
        }

        private void reviseCollectionButton_Click(object sender, EventArgs e)
        {
            RevisionForm rf = new RevisionForm((CollectionModel)collectionListBox.SelectedItem);
            rf.Show();
            this.Hide();
        }
    }
}
