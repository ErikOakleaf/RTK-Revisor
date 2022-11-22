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
        private int currentIndex = 0;

        //sample data


        public RevisionForm(CollectionModel collection)
        {
            this.collection = collection;
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            yesButton.Hide();
            noButton.Hide();
        }

        private void WireUpLists()
        {
            flashCardLabel.Text = collection.FlashCards[0].Word;
        }
    }
}
