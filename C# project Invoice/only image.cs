namespace C__project_Invoice
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double subtotal = double.Parse(subTotal.Text);
            double discountpercent = double.Parse(discountPercent.Text) / 100;
            double discountamount = subtotal * discountpercent;
            double mntax = double.Parse(mnTax.Text) / 100;
            double mntaxamount = subtotal * mntax;
            double total1 = subtotal - discountamount + mntax;
            discountAmount.Text = discountamount.ToString("N2");
            mnTaxAmount.Text = mntaxamount.ToString("N2");
            total.Text = total1.ToString("N2");
            discountPercent.Text = discountpercent.ToString("P1");
            mnTax.Text = mntax.ToString("P1");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void subTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}