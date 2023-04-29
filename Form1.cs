namespace Calculator
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private decimal num1 = 0;
        private decimal num2 = 0;
        private string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Text != "clear" && control.Text != "=")
                {
                    control.Click += NumberButton_Click;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBox1.Text += button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] operands = input.Split(new char[] { '+', '-', '*', ':' }, StringSplitOptions.RemoveEmptyEntries);
            string[] operators = input.Split(operands, StringSplitOptions.RemoveEmptyEntries);

            double result = double.Parse(operands[0]);

            for (int i = 0; i < operators.Length; i++)
            {
                double operand = double.Parse(operands[i + 1]);

                switch (operators[i])
                {
                    case "+":
                        result += operand;
                        break;
                    case "-":
                        result -= operand;
                        break;
                    case "*":
                        result *= operand;
                        break;
                    case ":":
                        result /= operand;
                        break;
                }
            }
           
            textBox1.Text = result.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "      ";
        }
    }
}