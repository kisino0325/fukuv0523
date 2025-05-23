namespace fukuv0523
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "kisinoryota";
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 10;
        }
    }
}
