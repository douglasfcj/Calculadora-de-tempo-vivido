namespace Calculadora_de_tempo_vivido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obt�m a data de nascimento informada pelo usu�rio
            DateTime dataNascimento = dateTimePicker1.Value;

            // Calcula a diferen�a entre a data atual e a data de nascimento
            TimeSpan diferenca = DateTime.Now - dataNascimento;

            // Calcula a dura��o em segundos, minutos e horas
            int segundos = (int)diferenca.TotalSeconds;
            int minutos = (int)diferenca.TotalMinutes;
            int horas = (int)diferenca.TotalHours;
            int dias = (int)diferenca.TotalDays;

            // Exibe os resultados para o usu�rio
            MessageBox.Show("Voc� j� viveu " + segundos + " segundos, " + minutos + " minutos, " + horas + " horas e " + dias + " dias.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}