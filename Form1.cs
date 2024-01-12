namespace ConcatenateTwoWords
{
    public partial class Form1 : Form
    {
        List<string> wordsArray = new List<string>();
        List<string> conWords = new List<string>();

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "--Words--";
            comboBox2.SelectedText = "--Words--";

        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text.Trim();

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("You have to enter a word it cannot be left blank");
                return;
            }

            if (comboBox1.Items.Contains(word) && comboBox2.Items.Contains(word))
            {
                MessageBox.Show("The word entered " + word + " already exits enter a another word");
                return;
            }



            comboBox1.Items.Add(textBox1.Text);
            comboBox2.Items.Add(textBox1.Text);
            MessageBox.Show(textBox1.Text + " has been added");

            textBox1.Clear();







        }

        private void rbRemove1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRemove1.Checked)
            {
                btnConcat.Text = "Remove items";
                comboBox1.SelectedItem.ToString();
            }
            else
            {
                btnConcat.Text = "Concatenate";
            }
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            string selWord = "";
            string selWord2 = "";
            string concatWord = "";
            string textRemove1 = "";
            string textRemove = "";

            selWord = comboBox1.SelectedItem.ToString();
            selWord2 = comboBox2.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a word from both the combo box");
                return;
            }

            if (rbRemove1.Checked)
            {
                textRemove = comboBox1.SelectedItem.ToString();
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                MessageBox.Show(textRemove + " has been removed from the list");
                return;
            }
            else if(rbRemove2.Checked)
            {
                textRemove1 = comboBox2.SelectedItem.ToString();
                comboBox2.Items.Remove(comboBox2.SelectedItem);
                MessageBox.Show(textRemove1 + " Has been removed from the list"); return;   

            }


            

            if (selWord == selWord2)
            {
                MessageBox.Show("You have to select different words on both lists");
            }
            concatWord = selWord + " " + selWord2;
            label5.Text = concatWord;
        }

        private void rbRemove2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRemove2.Checked)
            {
                btnConcat.Text = "Remove items";
                comboBox2.SelectedItem.ToString();
            }
            else
            {
                btnConcat.Text = "Concatenate";
            }
        }
        //private void RemoveWordFromComboBox(ComboBox comboBox)
        // {
        //     if (comboBox.SelectedIndex != -1)
        //     {
        //         comboBox.Items.RemoveAt(comboBox.SelectedIndex);
        //        // comboBox2.Items.RemoveAt(comboBox.SelectedIndex);
        //     }
        //     else
        //     {
        //         MessageBox.Show("Please select a word to remove.");
        //     }
        // }
    }
}
