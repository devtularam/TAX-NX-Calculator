namespace TAX_NX_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            rateBox.Text = "";
            sumResult.Text = "....";
            gtotal.Text = "....";
        }

        private void taxBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter an amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(rateBox.Text))
            {
                MessageBox.Show("Please Select Tax Rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double amnt = Convert.ToDouble(textBox1.Text);
            double rate = Convert.ToDouble(rateBox.Text);

            double result = (amnt * rate) / 100;

            sumResult.Text = result.ToString("F2");

            double grandtotal = amnt + result;

            gtotal.Text = grandtotal.ToString("F2");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter an amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(rateBox.Text))
            {
                MessageBox.Show("Please Select Tax Rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double amnt = Convert.ToDouble(textBox1.Text);
            double rate = Convert.ToDouble(rateBox.Text);

            double nxrate = (rate + 100) / 100;


            double result = amnt / nxrate;

            sumResult.Text = result.ToString("F2");

            gtotal.Text = "....";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are Your Sure You Wish To QUIT?", "Exit VAT / Net Calculator", MessageBoxButtons.YesNo);
            if(DialogResult==System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
