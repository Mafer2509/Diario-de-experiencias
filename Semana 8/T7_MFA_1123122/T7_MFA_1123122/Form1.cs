namespace T7_MFA_1123122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double x = 1;
            double sumatoria1= 0;
            double n = Convert.ToDouble(textBox1.Text);

           do
            {
                sumatoria1 = sumatoria1 + 1 / x;
                x++;

            }            
            while (x <= n);
            label4.Text = "Sumatoria:" + sumatoria1; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            double a = 1;
            double sumatoria2 = 0;
            double x = Convert.ToDouble(textBox1.Text);

            do
            {
                sumatoria2 = sumatoria2 + 1 / 1 (Math.Pow(2,0));
                Console.Read();
                a++;
            }
            while (a > 0);
            label5.Text = "Sumatoria:" + sumatoria2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }