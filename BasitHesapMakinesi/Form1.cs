namespace BasitHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, sonu�;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonu� = a + b;
            textBox3.Text = Convert.ToString(sonu�);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, sonu�;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonu� = a - b;
            textBox3.Text = Convert.ToString(sonu�);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, sonu�;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonu� = a * b;
            textBox3.Text = Convert.ToString(sonu�);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, sonu�;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonu� = a / b;
            textBox3.Text = Convert.ToString(sonu�);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}