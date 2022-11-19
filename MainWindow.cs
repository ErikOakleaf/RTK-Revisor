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

namespace RTK_Revisor
{
    public partial class MainWindow : Form
    {
        public string[] AllKanji { get; set; }
        public List<string> AvaliableKanji { get; set; } = new List<string>();
        public Regex JapaneseRegex { get; set; }
        public MainWindow()
        {
            AllKanji = File.ReadAllLines(TextConnectionProcessor.GetPath("data", "allKanji.csv"));
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
    }
}
