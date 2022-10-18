namespace L10_MFAM_JEGQ_1189222_123122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = 0;
                r = double.Parse(textBox1.Text);


                object Circulo;
            }
            catch
            {
                MessageBox.Show("Debe de ingresar un número");
            }

        }
    }
}