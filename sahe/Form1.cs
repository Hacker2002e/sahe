using static System.Windows.Forms.MonthCalendar;

namespace sahe
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

        private void button1_Click(object sender, EventArgs e)
        {
            int side;
            side = Convert.ToInt32(textBox1.Text);
            double area = Convert.ToDouble(textBox1.Text);
            double perimeter = Convert.ToDouble(textBox1.Text);
            area = (double)((int)(Math.Sqrt(3) * 3 / 2 * side * side * 100))/100;
            perimeter = 6 * side;
            label1.Text = $"Area: {area}, perimeter: {perimeter}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter the figure side: ";
            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int R;
            
            R = Convert.ToInt32(textBox2.Text);
            double area = Convert.ToDouble(textBox2.Text);
            double perimeter = Convert.ToDouble(textBox2.Text);
            area = (double)((int)(Math.PI*Math.Pow(R,2)* 100)) / 100;
            perimeter = 2*Math.PI*R;
            label2.Text = $"Area: {area}, perimeter: {perimeter}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Enter the figure side: ";
            textBox2.Text = "";
        }
    }
}