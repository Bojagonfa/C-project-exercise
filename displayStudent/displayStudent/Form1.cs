using System.Collections;

namespace displayStudent
{
    public partial class Form1 : Form
    {
        private ArrayList studentlist;

        private String[] ListWord = { "Solomon", "kebed", "alemu", "chala", "tamerat" };
        public Form1()
        {
            InitializeComponent();
            studentlist = new ArrayList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String student = textBox1.Text;
            if (!String.IsNullOrEmpty(student))
            {
                studentlist.Add(student);

            }
            else
            {
                MessageBox.Show("the value entered is invalid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String word = textBox2.Text;
            String reverse = "";
            for (int i = (word.Length - 1); i >= 0; i--)
            {
                reverse += word[i];
            }

            MessageBox.Show($"the value of the entered is reverse is ------------ {reverse}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String word1 = textBox3.Text;
            String word2 = textBox4.Text;

            MessageBox.Show($"the value entered is {word1 == word2}");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String word1 = textBox3.Text;
            String word2 = textBox4.Text;

            MessageBox.Show($"The value entered is compared {word1.Equals(word2)}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String word1 = textBox3.Text;
            String word2 = textBox4.Text;

            MessageBox.Show($"The value entered is {word1.CompareTo(word2)}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String word1 = textBox3.Text;
            String word2 = textBox4.Text;

            MessageBox.Show($"the comparationis \n with == \n\n =>{word1 == word2} \n\n with CompareTo \n\n =>{word1.CompareTo(word2)}  \n\n with Equals() \n\n =>{word1.Equals(word2)} \n\n this is the result of the by different comparaation ", "Comparation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var item in studentlist)
            {
                listBox1.Items.Add(item);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string searchText = textBox5.Text;
            listBox2.Items.Clear(); // Clear the items in listBox2 before adding new items

            foreach (string item in ListWord)
            {
                if (item.StartsWith(searchText))
                {
                    listBox2.Items.Add(item);
                }
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            foreach (String item in ListWord)
            {
                if (item.EndsWith(textBox5.Text))
                {
                    listBox2.Items.Add(item);
                }
            }
        }
    }
}