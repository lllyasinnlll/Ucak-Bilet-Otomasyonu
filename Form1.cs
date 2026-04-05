namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + " " + comboBox1.Text + " - " + comboBox2.Text + " " + "Tarih: " + dateTimePicker1.Text + " " + "Saat: " + " " + maskedTextBox1.Text);
            listBox2.Items.Add("Ad Soyad: " + " " + textBox1.Text + " " + "TC: " + " " + maskedTextBox2.Text + " " + "Telefon: " + " " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var i = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = i;

        }
    }
}
