using forms_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_app
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = context.Instructor.ToList();
        }

        Models.StudiesContext context = new Models.StudiesContext();

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                Instructor selectedOktató = new Instructor();
                selectedOktató.Salutation = f2.textBox1.Text;
                selectedOktató.Name = f2.textBox2.Text;
                context.Instructor.Add(selectedOktató);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                instructorBindingSource.DataSource = context.Instructor.ToList();

                MessageBox.Show("Sikeres mentés");

            }
            else
            {
                MessageBox.Show("Sikertelen felvétel");
            }
        }
    }
}
