namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string telefonnummer = textBox1.Text;
            string l�senord=textBox1.Text;

            if (l�senord == "hej123")
            {
                MessageBox.Show("inloggning lyckades");
            }
            else
            {
                MessageBox.Show("fel l�senord. f�rs�k igen");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "hej123";
        }
    }
}