namespace forms_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUC1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
            panel1.BackColor = Color.Fuchsia;
        }

        private void buttonUC2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc2 = new UserControl2();
            panel1.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill;
            panel1.BackColor = Color.DarkOrange;
        }

        private void buttonUC3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 uc3 = new UserControl3();
            panel1.Controls.Add(uc3);
            uc3.Dock = DockStyle.Fill;
            panel1.BackColor = Color.DarkCyan;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ki akar lépni?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}