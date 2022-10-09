namespace T8_MFAM_1123122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            string binario = "";
            
            while (a > 0)
            {
                binario = a%2 + binario;
                a = a / 2;
            }
            label3.Text = binario;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int numero= int.Parse(textBox2.Text);
            string Hexadecimal = Convert.ToString(numero, 16);
            label6.Text = Hexadecimal;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}