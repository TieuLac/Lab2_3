namespace Lab2_3
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

        private void button1_Click(object sender, EventArgs e)
        {

            double a =
            double.Parse(txtA.Text); double b =
            double.Parse(txtB.Text); double c =
            a + b;
            txtKetQua.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a =
            double.Parse(txtA.Text); double b =
            double.Parse(txtB.Text); double c =
            a - b;
            txtKetQua.Text = c.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a =
            double.Parse(txtA.Text); double b =
            double.Parse(txtB.Text); double c =
            a * b;
            txtKetQua.Text = c.ToString();
        }
    }
}